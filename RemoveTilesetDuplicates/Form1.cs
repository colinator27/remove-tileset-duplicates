using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveTilesetDuplicates
{
    public partial class Form1 : Form
    {

        string tileWidthWorking = "20";
        string tileHeightWorking = "20";
        string imageWidthWorking = "100";
        string imageHeightWorking = "100";

        public Form1()
        {
            InitializeComponent();
            if (!useInputWidth.Checked)
            {
                finalImageWidthLabel.Visible = true;
                imageWidthTextBox.Visible = true;
                finalImageHeightLabel.Visible = true;
                imageHeightTextBox.Visible = true;
            }
            else
            {
                finalImageWidthLabel.Visible = false;
                imageWidthTextBox.Visible = false;
                finalImageHeightLabel.Visible = false;
                imageHeightTextBox.Visible = false;
            }
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Portable Network Graphics (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BitmapHandler.inputImage = new Bitmap(openFileDialog1.FileName);
                    openImageButton.Text = openFileDialog1.SafeFileName;
                    imageWidthTextBox.Text = BitmapHandler.inputImage.Width.ToString();
                    imageHeightTextBox.Text = BitmapHandler.inputImage.Height.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void useInputWidth_CheckedChanged(object sender, EventArgs e)
        {
            if (!useInputWidth.Checked)
            {
                finalImageWidthLabel.Visible = true;
                imageWidthTextBox.Visible = true;
                finalImageHeightLabel.Visible = true;
                imageHeightTextBox.Visible = true;
            }
            else
            {
                finalImageWidthLabel.Visible = false;
                imageWidthTextBox.Visible = false;
                finalImageHeightLabel.Visible = false;
                imageHeightTextBox.Visible = false;
            }
        }

        private void tileWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(tileWidthTextBox.Text, out n);
            if (!isNumeric)
            {
                if (tileWidthTextBox.Text == "")
                {

                }
                else
                {
                    tileWidthTextBox.Text = tileWidthWorking;
                }
            } else
            {
                
                if(n > 1) tileWidthWorking = tileWidthTextBox.Text;
            }
        }
        private void tileWidthTextBox_Leave(object sender, EventArgs e)
        {
            if(tileWidthTextBox.Text == "")
            {
                tileWidthTextBox.Text = tileWidthWorking;
            } else
            {
                int n;
                bool isNumeric = int.TryParse(tileWidthTextBox.Text, out n);
                if (isNumeric && n <= 1)
                {
                    tileWidthTextBox.Text = tileWidthWorking;
                }
                else if (isNumeric)
                {
                    int fiw;
                    bool num = int.TryParse(imageWidthTextBox.Text, out fiw);
                    if (num)
                    {
                        if (fiw < n)
                        {
                            imageWidthTextBox.Text = n.ToString();
                        }
                    }
                }
            }
        }

        private void tileHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(tileHeightTextBox.Text, out n);
            if (!isNumeric)
            {
                if (tileHeightTextBox.Text == "")
                {

                }
                else
                {
                    tileHeightTextBox.Text = tileHeightWorking;
                }
            }
            else
            {
                if(n > 1) tileHeightWorking = tileHeightTextBox.Text;
            }
        }
        private void tileHeightTextBox_Leave(object sender, EventArgs e)
        {
            if (tileHeightTextBox.Text == "")
            {
                tileHeightTextBox.Text = tileHeightWorking;
            } else
            {
                int n;
                bool isNumeric = int.TryParse(tileHeightTextBox.Text, out n);
                if (isNumeric && n <= 1)
                {
                    tileHeightTextBox.Text = tileHeightWorking;
                } else if (isNumeric)
                {
                    int fih;
                    bool num = int.TryParse(imageHeightTextBox.Text, out fih);
                    if (num)
                    {
                        if(fih < n)
                        {
                            imageHeightTextBox.Text = n.ToString();
                        }
                    }
                }
            }
        }

        private void imageWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(imageWidthTextBox.Text, out n);
            if (!isNumeric)
            {
                if (imageWidthTextBox.Text == "")
                {

                }
                else
                {
                    imageWidthTextBox.Text = imageWidthWorking;
                }
            }
            else
            {
                int tw;
                bool num = int.TryParse(tileWidthTextBox.Text, out tw);

                if (!num)
                {
                    imageWidthWorking = imageWidthTextBox.Text;
                }
                else
                {
                    if (n >= tw)
                    {
                        imageWidthWorking = imageWidthTextBox.Text;
                    }
                }
            }
        }

        private void imageWidthTextBox_Leave(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(imageWidthTextBox.Text, out n);

            if (isNumeric)
            {
                int tw;
                bool unused = int.TryParse(tileWidthTextBox.Text, out tw);

                if (n < tw)
                {
                    MessageBox.Show("Width is too low.");
                    imageWidthTextBox.Text = imageWidthWorking;
                }
            } else
            {
                imageWidthTextBox.Text = imageWidthWorking;
            }
        }

        private void imageHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(imageHeightTextBox.Text, out n);
            if (!isNumeric)
            {
                if (imageHeightTextBox.Text == "")
                {

                }
                else
                {
                    imageHeightTextBox.Text = imageHeightWorking;
                }
            }
            else
            {
                int tw;
                bool num = int.TryParse(tileHeightTextBox.Text, out tw);

                if (!num)
                {
                    imageHeightWorking = imageHeightTextBox.Text;
                } else
                {
                    if(n >= tw)
                    {
                        imageHeightWorking = imageHeightTextBox.Text;
                    }
                }

            }
        }

        private void imageHeightTextBox_Leave(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(imageHeightTextBox.Text, out n);

            if (isNumeric)
            {
                int tw;
                bool unused = int.TryParse(tileHeightTextBox.Text, out tw);

                if (n < tw)
                {
                    MessageBox.Show("Height is too low.");
                    imageHeightTextBox.Text = imageHeightWorking;
                }
            }
            else
            {
                imageHeightTextBox.Text = imageHeightWorking;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

            int tileheight = 0;
            bool tileheightnum = int.TryParse(tileHeightTextBox.Text, out tileheight);
            int tilewidth = 0;
            bool tilewidthnum = int.TryParse(tileWidthTextBox.Text, out tilewidth);
            int imgwidth = 0;
            bool imgwidthnum = int.TryParse(imageWidthTextBox.Text, out imgwidth);
            int imgheight = 0;
            bool imgheightnum = int.TryParse(imageHeightTextBox.Text, out imgheight);

            if(!tileheightnum || !tilewidthnum || !imgwidthnum || !imgheightnum)
            {
                MessageBox.Show("Error parsing integers.");
                return;
            }

            if(BitmapHandler.inputImage == null)
            {
                MessageBox.Show("You must open a tileset first!");
                return;
            }

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Portable Network Graphics (*.png)|*.png";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    BitmapHandler.getNewTileset(tileheight, tilewidth, useInputWidth.Checked, imgwidth, imgheight).Save(myStream,BitmapHandler.inputImage.RawFormat);
                    myStream.Close();

                    MessageBox.Show("Export complete.");
                }
            }
        }

        private void shiftTilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BitmapHandler.noshift = shiftTilesCheckBox.Checked;
        }
    }
}
