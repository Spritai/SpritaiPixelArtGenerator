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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 454);
            Controls.Add(ThemeButton);
            Name = "Form1";
            Text = "Spritai's Pixel Art";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ThemeButton;
    }
}
