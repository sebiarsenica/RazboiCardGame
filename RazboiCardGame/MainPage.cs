using Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Text;

namespace RazboiCardGame
{
    public partial class MainPage : MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal900, Primary.Cyan900, Primary.Red700, Accent.Cyan100, TextShade.WHITE);

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //privateFontCollection.AddFontFile("‪C:\\Users\\victo\\AppData\\Local\\Microsoft\\Windows\\Fonts\\ARCADECLASSIC.TTF");
            privateFontCollection.AddFontFile("D:\\ARCADECLASSIC.TTF");

            foreach (Control c in panelMenu.Controls)
            {
                c.Font = new Font(privateFontCollection.Families[0], 15, FontStyle.Regular);
            }

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } //Open new form


        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(128, 0, 128);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMenu.BackgroundImage = null;
            foreach (Control c in panelMenu.Controls)
            {
                c.Visible = false;
            }
            

            openChildForm(new Game());


        }


    }
}