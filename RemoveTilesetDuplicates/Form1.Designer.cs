namespace RemoveTilesetDuplicates
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tileWidthTextBox = new System.Windows.Forms.TextBox();
            this.tileHeightTextBox = new System.Windows.Forms.TextBox();
            this.finalImageWidthLabel = new System.Windows.Forms.Label();
            this.imageWidthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openImageButton = new System.Windows.Forms.Button();
            this.useInputWidth = new System.Windows.Forms.CheckBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.finalImageHeightLabel = new System.Windows.Forms.Label();
            this.imageHeightTextBox = new System.Windows.Forms.TextBox();
            this.shiftTilesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tile Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tile Height:";
            // 
            // tileWidthTextBox
            // 
            this.tileWidthTextBox.Location = new System.Drawing.Point(76, 60);
            this.tileWidthTextBox.Name = "tileWidthTextBox";
            this.tileWidthTextBox.Size = new System.Drawing.Size(39, 20);
            this.tileWidthTextBox.TabIndex = 2;
            this.tileWidthTextBox.Text = "20";
            this.tileWidthTextBox.TextChanged += new System.EventHandler(this.tileWidthTextBox_TextChanged);
            this.tileWidthTextBox.Leave += new System.EventHandler(this.tileWidthTextBox_Leave);
            // 
            // tileHeightTextBox
            // 
            this.tileHeightTextBox.Location = new System.Drawing.Point(76, 92);
            this.tileHeightTextBox.Name = "tileHeightTextBox";
            this.tileHeightTextBox.Size = new System.Drawing.Size(39, 20);
            this.tileHeightTextBox.TabIndex = 3;
            this.tileHeightTextBox.Text = "20";
            this.tileHeightTextBox.TextChanged += new System.EventHandler(this.tileHeightTextBox_TextChanged);
            this.tileHeightTextBox.Leave += new System.EventHandler(this.tileHeightTextBox_Leave);
            // 
            // finalImageWidthLabel
            // 
            this.finalImageWidthLabel.AutoSize = true;
            this.finalImageWidthLabel.Location = new System.Drawing.Point(12, 187);
            this.finalImageWidthLabel.Name = "finalImageWidthLabel";
            this.finalImageWidthLabel.Size = new System.Drawing.Size(95, 13);
            this.finalImageWidthLabel.TabIndex = 4;
            this.finalImageWidthLabel.Text = "Final Image Width:";
            // 
            // imageWidthTextBox
            // 
            this.imageWidthTextBox.Location = new System.Drawing.Point(113, 184);
            this.imageWidthTextBox.Name = "imageWidthTextBox";
            this.imageWidthTextBox.Size = new System.Drawing.Size(48, 20);
            this.imageWidthTextBox.TabIndex = 5;
            this.imageWidthTextBox.Text = "100";
            this.imageWidthTextBox.TextChanged += new System.EventHandler(this.imageWidthTextBox_TextChanged);
            this.imageWidthTextBox.Leave += new System.EventHandler(this.imageWidthTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input Image File:";
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(103, 9);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(105, 23);
            this.openImageButton.TabIndex = 7;
            this.openImageButton.Text = "Open...";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // useInputWidth
            // 
            this.useInputWidth.AutoSize = true;
            this.useInputWidth.Checked = true;
            this.useInputWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useInputWidth.Location = new System.Drawing.Point(15, 158);
            this.useInputWidth.Name = "useInputWidth";
            this.useInputWidth.Size = new System.Drawing.Size(154, 17);
            this.useInputWidth.TabIndex = 9;
            this.useInputWidth.Text = "Use Input File Dimensions?";
            this.useInputWidth.UseVisualStyleBackColor = true;
            this.useInputWidth.CheckedChanged += new System.EventHandler(this.useInputWidth_CheckedChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(15, 243);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 36);
            this.exportButton.TabIndex = 10;
            this.exportButton.Text = "Save and Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // finalImageHeightLabel
            // 
            this.finalImageHeightLabel.AutoSize = true;
            this.finalImageHeightLabel.Location = new System.Drawing.Point(12, 214);
            this.finalImageHeightLabel.Name = "finalImageHeightLabel";
            this.finalImageHeightLabel.Size = new System.Drawing.Size(98, 13);
            this.finalImageHeightLabel.TabIndex = 11;
            this.finalImageHeightLabel.Text = "Final Image Height:";
            // 
            // imageHeightTextBox
            // 
            this.imageHeightTextBox.Location = new System.Drawing.Point(113, 211);
            this.imageHeightTextBox.Name = "imageHeightTextBox";
            this.imageHeightTextBox.Size = new System.Drawing.Size(48, 20);
            this.imageHeightTextBox.TabIndex = 12;
            this.imageHeightTextBox.Text = "100";
            this.imageHeightTextBox.TextChanged += new System.EventHandler(this.imageHeightTextBox_TextChanged);
            this.imageHeightTextBox.Leave += new System.EventHandler(this.imageHeightTextBox_Leave);
            // 
            // shiftTilesCheckBox
            // 
            this.shiftTilesCheckBox.AutoSize = true;
            this.shiftTilesCheckBox.Location = new System.Drawing.Point(15, 128);
            this.shiftTilesCheckBox.Name = "shiftTilesCheckBox";
            this.shiftTilesCheckBox.Size = new System.Drawing.Size(100, 17);
            this.shiftTilesCheckBox.TabIndex = 13;
            this.shiftTilesCheckBox.Text = "Don\'t Shift Tiles";
            this.shiftTilesCheckBox.UseVisualStyleBackColor = true;
            this.shiftTilesCheckBox.CheckedChanged += new System.EventHandler(this.shiftTilesCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.shiftTilesCheckBox);
            this.Controls.Add(this.imageHeightTextBox);
            this.Controls.Add(this.finalImageHeightLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.useInputWidth);
            this.Controls.Add(this.openImageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageWidthTextBox);
            this.Controls.Add(this.finalImageWidthLabel);
            this.Controls.Add(this.tileHeightTextBox);
            this.Controls.Add(this.tileWidthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Remove Tileset Duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tileWidthTextBox;
        private System.Windows.Forms.TextBox tileHeightTextBox;
        private System.Windows.Forms.Label finalImageWidthLabel;
        private System.Windows.Forms.TextBox imageWidthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.CheckBox useInputWidth;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label finalImageHeightLabel;
        private System.Windows.Forms.TextBox imageHeightTextBox;
        private System.Windows.Forms.CheckBox shiftTilesCheckBox;
    }
}

