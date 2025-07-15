namespace SpritaiPixelArtGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ThemeButton = new MaterialSkin.Controls.MaterialButton();
            btnImport = new MaterialSkin.Controls.MaterialButton();
            btnPixelize = new MaterialSkin.Controls.MaterialButton();
            pictureBoxOriginal = new PictureBox();
            pictureBoxPixelated = new PictureBox();
            pixelSizeInput = new NumericUpDown();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPixelated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pixelSizeInput).BeginInit();
            SuspendLayout();
            // 
            // ThemeButton
            // 
            ThemeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ThemeButton.AutoSize = false;
            ThemeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ThemeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ThemeButton.Depth = 0;
            ThemeButton.HighEmphasis = true;
            ThemeButton.Icon = null;
            ThemeButton.Location = new Point(659, 70);
            ThemeButton.Margin = new Padding(4, 6, 4, 6);
            ThemeButton.MouseState = MaterialSkin.MouseState.HOVER;
            ThemeButton.Name = "ThemeButton";
            ThemeButton.NoAccentTextColor = Color.Empty;
            ThemeButton.Size = new Size(60, 30);
            ThemeButton.TabIndex = 0;
            ThemeButton.Text = "Theme";
            ThemeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ThemeButton.UseAccentColor = false;
            ThemeButton.UseVisualStyleBackColor = true;
            ThemeButton.Click += ThemeButton_Click;
            // 
            // btnImport
            // 
            btnImport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImport.Depth = 0;
            btnImport.HighEmphasis = true;
            btnImport.Icon = null;
            btnImport.Location = new Point(7, 83);
            btnImport.Margin = new Padding(4, 6, 4, 6);
            btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            btnImport.Name = "btnImport";
            btnImport.NoAccentTextColor = Color.Empty;
            btnImport.Size = new Size(76, 36);
            btnImport.TabIndex = 1;
            btnImport.Text = "IMPORT";
            btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImport.UseAccentColor = false;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnPixelize
            // 
            btnPixelize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPixelize.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPixelize.Depth = 0;
            btnPixelize.HighEmphasis = true;
            btnPixelize.Icon = null;
            btnPixelize.Location = new Point(91, 83);
            btnPixelize.Margin = new Padding(4, 6, 4, 6);
            btnPixelize.MouseState = MaterialSkin.MouseState.HOVER;
            btnPixelize.Name = "btnPixelize";
            btnPixelize.NoAccentTextColor = Color.Empty;
            btnPixelize.Size = new Size(82, 36);
            btnPixelize.TabIndex = 2;
            btnPixelize.Text = "Pixelize";
            btnPixelize.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPixelize.UseAccentColor = false;
            btnPixelize.UseVisualStyleBackColor = true;
            btnPixelize.Click += btnPixelize_Click;
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.Location = new Point(32, 168);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(302, 207);
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOriginal.TabIndex = 3;
            pictureBoxOriginal.TabStop = false;
            pictureBoxOriginal.Click += pictureBoxOriginal_Click;
            // 
            // pictureBoxPixelated
            // 
            pictureBoxPixelated.Location = new Point(391, 168);
            pictureBoxPixelated.Name = "pictureBoxPixelated";
            pictureBoxPixelated.Size = new Size(302, 207);
            pictureBoxPixelated.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPixelated.TabIndex = 4;
            pictureBoxPixelated.TabStop = false;
            pictureBoxPixelated.Click += pictureBoxPixelated_Click;
            // 
            // pixelSizeInput
            // 
            pixelSizeInput.Location = new Point(180, 92);
            pixelSizeInput.Name = "pixelSizeInput";
            pixelSizeInput.Size = new Size(120, 23);
            pixelSizeInput.TabIndex = 5;
            pixelSizeInput.ValueChanged += pixelSizeInput_ValueChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 432);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(146, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Spritai's Pixel Art 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 454);
            Controls.Add(materialLabel1);
            Controls.Add(pixelSizeInput);
            Controls.Add(pictureBoxPixelated);
            Controls.Add(pictureBoxOriginal);
            Controls.Add(btnPixelize);
            Controls.Add(btnImport);
            Controls.Add(ThemeButton);
            Name = "Form1";
            Text = "Spritai's Pixel Art";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPixelated).EndInit();
            ((System.ComponentModel.ISupportInitialize)pixelSizeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ThemeButton;
        private MaterialSkin.Controls.MaterialButton btnImport;
        private MaterialSkin.Controls.MaterialButton btnPixelize;
        private PictureBox pictureBoxOriginal;
        private PictureBox pictureBoxPixelated;
        private NumericUpDown pixelSizeInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
