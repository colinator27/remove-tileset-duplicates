using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveTilesetDuplicates
{
    public class BitmapHandler
    {
        public static Bitmap inputImage = null;
        public static bool loaded = false;
        public static bool noshift = false;

        //Partial code from http://stackoverflow.com/questions/9616617/c-sharp-copy-paste-an-image-region-into-another-image
        public static void copyIntoImage(Bitmap srcBitmap, ref Bitmap destBitmap, Rectangle destRegion)
        {
            Rectangle srcRegion = new Rectangle(0,0,srcBitmap.Width,srcBitmap.Height);
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }
        //End of stackoverflow.com/questions/9616617/c-sharp-copy-paste-an-image-region-into-another-image

        public static Bitmap[] getTiles(Bitmap image, int tileWidth, int tileHeight)
        {
            Rectangle rect;

            int finalWidth = image.Width;

            int finalHeight = image.Height;

            double rpre = Math.Floor((double)finalWidth / (double)tileWidth);

            int rows = Convert.ToInt32(rpre);

            double cpre = Math.Floor((double)finalHeight / (double)tileHeight);

            int columns = Convert.ToInt32(cpre);

            int x = 0;
            int y = 0;

            List<Bitmap> bmplist = new List<Bitmap>();

            for (y = 0; y < columns; y++)
            {
                for (x = 0; x < rows; x++)
                {
                    rect = new Rectangle(x*tileWidth,y*tileHeight,tileWidth,tileHeight);
                    PixelFormat format = image.PixelFormat;
                    bmplist.Add(image.Clone(rect, format));
                }
            }

            return bmplist.ToArray();
        }

        public static Bitmap[] removeDuplicates(Bitmap[] tiles)
        {
            for(int i = 0; i < tiles.Length; i++)
            {
                Bitmap fTile;
                if (tiles[i] != null)
                {
                    fTile = tiles[i];
                } else
                {
                    fTile = new Bitmap(5, 5);
                }
                for(int i2 = 0; i2 < tiles.Length; i2++)
                {
                    if(i2 != i && tiles[i2] != null)
                    {
                        if(ComparingImages.Compare(fTile,tiles[i2]) == ComparingImages.CompareResult.ciCompareOk)
                        {
                            if (!noshift)
                            {
                                for (int i3 = i2; i3 < tiles.Length; i3++)
                                {
                                    if (i3 < tiles.Length - 1)
                                    {
                                        tiles[i3] = tiles[i3 + 1];
                                    }
                                    else
                                    {
                                        tiles[i3] = null;
                                    }
                                }
                            } else
                            {
                                tiles[i2] = null;
                            }
                        }
                    }
                }
            }

            return tiles;
        }

        public static Bitmap getNewTileset(int tileWidth, int tileHeight, bool customDims, int exportWidth, int exportHeight)
        {
            Bitmap input = inputImage;
            Rectangle rect;

            customDims = !customDims;

            int finalWidth = input.Width;
            if (customDims) finalWidth = exportWidth;

            int finalHeight = input.Height;
            if (customDims) finalHeight = exportHeight;

            double rpre = Math.Floor((double)finalWidth / (double)tileWidth);

            int rows = Convert.ToInt32(rpre);

            if (rows <= 0)
            {
                MessageBox.Show("Error: 0 rows.");
            }

            double cpre = Math.Floor((double)finalHeight / (double)tileHeight);

            int columns = Convert.ToInt32(cpre);

            if (columns <= 0)
            {
                MessageBox.Show("Error: 0 columns.");
            }

            Bitmap[] tiles = removeDuplicates(getTiles(input, tileWidth, tileHeight));

            int tilecount = 0;
            int i = 0;

            for (i = 0; i < tiles.Length; i++)
            {
                if(tiles[i] == null)
                {
                    i = tiles.Length;
                } else
                {
                    tilecount++;
                }
            }

            if((columns * rows) < tilecount)
            {
                MessageBox.Show("Error: Export image size too small.");
                return null;
            }

            Bitmap final = new Bitmap(finalWidth, finalHeight);

            int x = 0;
            int y = 0;
            i = 0;

            for (y = 0; y < columns; y++)
            {
                for (x = 0; x < rows; x++)
                {
                    rect = new Rectangle(x*tileWidth,y*tileHeight,tileWidth,tileHeight);
                    if (i < tiles.Length)
                    {
                        if(tiles[i] != null) copyIntoImage(tiles[i],ref final,rect);
                        i++;
                    }
                }
            }

            return final;
        }
    }
}
