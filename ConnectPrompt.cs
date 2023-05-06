using System.Runtime.InteropServices;

namespace TSAnalog
{
    public partial class ConnectPrompt : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);
        public ConnectPrompt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBrowse.Enabled = false;
            btnConnect.Enabled = false;
            tbPath.Enabled = false;
            btnConnect.BackColor = Color.Yellow;
            btnConnect.Text = "Connecting";
            if (!File.Exists($"{tbPath.Text}/Raildriver64.dll"))
            {
                MessageBox.Show($"The path {tbPath.Text} doesn't contain Raildriver64.dll. Make sure you selected the correct folder.");
                return;
            }
            SetDllDirectory(tbPath.Text);
            if (!TS.Connect())
            {
                MessageBox.Show("Please make sure Train Simulator Classic is running.", "Connection unsuccessful");
                btnBrowse.Enabled = true;
                btnConnect.Enabled = true;
                tbPath.Enabled = true;
                btnConnect.BackColor = Color.Red;
                btnConnect.Text = "Connect";
                return;
            }
            btnConnect.BackColor = Color.Green;
            MessageBox.Show("Connection to Train Sim was successful.", "Connected");
            Close();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.InitialDirectory = tbPath.Text;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;
            tbPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}