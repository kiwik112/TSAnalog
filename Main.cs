using SharpDX.DirectInput;
using System.Diagnostics;

namespace TSAnalog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll"))
            {
                MessageBox.Show("Shid.");
                Environment.Exit(0);
            }
            TS.Connect();
            string[] locoPath = TS.GetData()[0].Split(".:.");
            Text = locoPath[locoPath.Length - 1];
            lsBxDevices.Items.Clear();
            btnAdd.Enabled = true;
            MessageBox.Show($"Connected to {locoPath[locoPath.Length - 1]}.", "Success");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DeviceDialog deviceDialog = new DeviceDialog();
            deviceDialog.ShowDialog();

            foreach (Joystick joystick in Interface.GetActiveJoysticks())
            {
                Debug.WriteLine($"Niga {joystick.Information.InstanceGuid}; {joystick.Information.ProductGuid}");
            }

            updateDeviceList();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls { device = lsBxDevices.SelectedIndex };
            controls.ShowDialog();

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lsBxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void updateDeviceList()
        {
            lsBxDevices.Items.Clear();
            foreach (Joystick joystick in Interface.GetActiveJoysticks()) lsBxDevices.Items.Add(joystick.Information.ProductName);
        }
    }
}
