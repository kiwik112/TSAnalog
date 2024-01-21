using SharpDX.DirectInput;

namespace TSAnalog
{
    public partial class DeviceDialog : Form
    {
        public DeviceDialog()
        {
            InitializeComponent();
        }

        private void DeviceDialog_Load(object sender, EventArgs e)
        {
            loadDevices();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDevices();
        }

        List<Joystick> displayedDevices = new List<Joystick>();

        private void loadDevices()
        {
            lsBxDevice.Items.Clear();
            displayedDevices.Clear();
            Joystick[] devices = DI.GetDevices();
            foreach (Joystick device in devices)
            {
                if (isActive(device)) continue;
                lsBxDevice.Items.Add(device.Information.ProductName);
                displayedDevices.Add(device);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Device device = new Device();
            device.joystick = displayedDevices[lsBxDevice.SelectedIndex];
            device.joystick.Properties.BufferSize = 512;
            device.joystick.Acquire();
            Interface.ActiveDevices.Add(device);
            Close();
        }

        private void lsBxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = lsBxDevice.SelectedIndex >= 0;
        }

        private bool isActive(Joystick joystick)
        {
            foreach (Joystick device in Interface.GetActiveJoysticks())
            {
                if (device.Information.InstanceGuid == joystick.Information.InstanceGuid) return true;
            }
            return false;
        }
    }
}
