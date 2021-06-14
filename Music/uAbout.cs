using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class uAbout : UserControl
    {
        public uAbout()
        {
            InitializeComponent();
            label5.Text = Properties.Settings.Default.version;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:saranaji514@gmail.com");
            System.Diagnostics.Process.Start("mailto:yaren.kkasimoglu@gmail.com");

        }
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            label1.Text =  resource.GetString("version", culture);
            label3.Text = resource.GetString("label_About", culture);
            label4.Text = resource.GetString("label_Contact", culture);
        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }
    }
}
