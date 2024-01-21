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
#if DEBUG
			if (!File.Exists(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll"))
#else
			if (!File.Exists("..\\Raildriver64.dll"))
#endif
			{
				MessageBox.Show("Make sure you place this program into the 'RailWorks\\plugins\\' folder");
				Environment.Exit(0);
			}
			TS.Connect();
			string[] locoPath = TS.GetData()[0].Split(".:.");
			Text = locoPath[locoPath.Length - 1];
			lsBxDevices.Items.Clear();
			updateLocks();
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

			updateLocks();
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

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void lsBxDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateLocks();
		}

		private void updateDeviceList()
		{
			lsBxDevices.Items.Clear();
			foreach (Joystick joystick in Interface.GetActiveJoysticks()) lsBxDevices.Items.Add(joystick.Information.ProductName);
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!Interface.running)
			{
				Interface.running = true;

				updateLocks();

				for (int i = 0; i < Interface.ActiveDevices.Count; i++)
				{
					Debug.WriteLine("Starting thread: " + i);
					Interface.StartJoyThread(i);
				}
				startToolStripMenuItem.Text = "Stop";
				return;
			}

			Interface.running = false;

			updateLocks();
			startToolStripMenuItem.Text = "Start";
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void debugToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			DebugTool debugTool = new DebugTool();
			debugTool.ShowDialog();
		}

		private void updateLocks()
		{
			bool connected = TS.GetRailSimConnected();
			btnAdd.Enabled = connected && !Interface.running;
			debugToolStripMenuItem.Enabled = connected && !Interface.running;
			startToolStripMenuItem.Enabled = lsBxDevices.Items.Count > 0;
			btnEdit.Enabled = connected && lsBxDevices.SelectedIndex >= 0 && !Interface.running;
			btnRemove.Enabled = connected && lsBxDevices.SelectedIndex >= 0 && !Interface.running;
			connectToolStripMenuItem.Enabled = !connected;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to remove '" + Interface.ActiveDevices[lsBxDevices.SelectedIndex].joystick.Information.ProductName + "' ?", "", MessageBoxButtons.YesNo);
			if (result == DialogResult.No) return;
			Interface.ActiveDevices.RemoveAt(lsBxDevices.SelectedIndex);
			updateDeviceList();
			updateLocks();
		}
	}
}
