using MaterialSkin;
using MaterialSkin.Controls;

namespace SpritaiPixelArtGenerator
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private bool isDarkTheme = false; // Variable pour suivre l'état du thème

        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this); // IMPORTANT : ajoute le form au gestionnaire
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
    }
}