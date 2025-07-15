using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpritaiPixelArtGenerator
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private bool isDarkTheme = false;
        private Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                isDarkTheme = false;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                isDarkTheme = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(ofd.FileName);
                    pictureBoxOriginal.Image = originalImage;
                }
            }
        }

        private void btnPixelize_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Veuillez d'abord importer une image.");
                return;
            }

            int pixelSize = (int)pixelSizeInput.Value;
            Bitmap pixelated = PixelizeImage(originalImage, pixelSize);
            pictureBoxPixelated.Image = pixelated;
        }

        private Bitmap PixelizeImage(Bitmap original, int pixelSize)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                for (int y = 0; y < original.Height; y += pixelSize)
                {
                    for (int x = 0; x < original.Width; x += pixelSize)
                    {
                        Color pixelColor = original.GetPixel(x, y);
                        using (Brush brush = new SolidBrush(pixelColor))
                        {
                            g.FillRectangle(brush, x, y, pixelSize, pixelSize);
                        }
                    }
                }
            }

            return result;
        }

        private void pixelSizeInput_ValueChanged(object sender, EventArgs e)
        {
            // Ce code peut rester vide si tu ne fais rien à chaque changement.
        }

        private void pictureBoxOriginal_Click(object sender, EventArgs e)
        {
            // Optionnel : zoom, outil pipette, etc.
        }

        private void pictureBoxPixelated_Click(object sender, EventArgs e)
        {
            // Optionnel : enregistrement rapide par clic ?
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}