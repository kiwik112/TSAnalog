using SharpDX.DirectInput;
using System.Diagnostics;

namespace TSAnalog
{
	public partial class ControlDialog : Form
	{
		public int device;
		public int control;
		public bool previewActive = false;
		public bool inverted = false;
		public string previewAxis = "";
		public ControlDialog()
		{
			InitializeComponent();
		}

		private void ControlDialog_Load(object sender, EventArgs e)
		{
			string[] controls = TS.GetData()[1].Split("::");
			foreach (string control in controls)
			{
				lsBxControl.Items.Add(control);
			}

			int axisIndex = -1;
			bool updatingAxis = true;

			Control c = Interface.ActiveDevices[device].controls[control];

			foreach (JoystickOffset axis in DI.GetAxes(Interface.ActiveDevices[device].joystick))
			{
				if (updatingAxis) axisIndex++;
				comboAxis.Items.Add(axis.ToString());
				if (axis == c.axis) updatingAxis = false;
			}

			tbName.Text = c.name;
			comboAxis.SelectedIndex = axisIndex;
			chkbxInvert.Checked = c.inverted;
			udMin.Value = c.joyMin;
			udMax.Value = c.joyMax;
			lsBxControl.SelectedIndex = c.tsid;
			udTMin.Value = (decimal)c.trainMin;
			udTMax.Value = (decimal)c.trainMax;

			updateLocks();
		}

		private void comboAxis_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboAxis.SelectedIndex == -1)
			{
				previewActive = false;
				if (lsBxControl.SelectedIndex >= 0) chkbxInject.Enabled = true;
				return;
			}
			previewAxis = comboAxis.Text;

			updateLocks();

			if (previewActive) return;
			previewActive = true;
			Thread thread = new Thread(preview);
			thread.Start();
		}

		private void preview()
		{
			while (previewActive)
			{
				Debug.WriteLine("loop");
				Thread.Sleep(10);
				double position = (double)DI.Get(Interface.ActiveDevices[device].joystick, previewAxis);
				if (position < 0) continue;
				int value = (int)(position / 65535.0 * 99.0);
				if (inverted) value = 99 - value;
				Debug.WriteLine(value);
				try { Invoke(new Action(() => { progAxis.Value = value + 1; progAxis.Value = value; })); }
				catch { }
			}
		}

		private void chkbxInvert_CheckedChanged(object sender, EventArgs e)
		{
			inverted = chkbxInvert.Checked;
		}

		private void lsBxControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lsBxControl.SelectedIndex >= 0 && comboAxis.SelectedIndex >= 0) { chkbxInject.Enabled = true; if (tbName.Text.Trim() == "") btnSave.Enabled = true; }
			float[] limits = TS.GetControl(lsBxControl.SelectedIndex);
			udTMin.Minimum = (decimal)limits[1];
			udTMax.Minimum = (decimal)limits[1];
			udTMin.Maximum = (decimal)limits[2];
			udTMax.Maximum = (decimal)limits[2];

			udTMin.Value = (decimal)limits[1];
			udTMax.Value = (decimal)limits[2];

			updateLocks();
		}

		private void chkbxInject_CheckedChanged(object sender, EventArgs e)
		{
			if (!chkbxInject.Checked)
			{
				Interface.running = false;
				return;
			}
			Interface.running = true;
			Interface.StartJoyThread(device);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Interface.ActiveDevices[device].controls[control].inverted = inverted;
			Interface.ActiveDevices[device].controls[control].name = tbName.Text;
			Interface.ActiveDevices[device].controls[control].axis = DI.GetAxes(Interface.ActiveDevices[device].joystick)[comboAxis.SelectedIndex];
			Interface.ActiveDevices[device].controls[control].joyMax = (int)udMax.Value;
			Interface.ActiveDevices[device].controls[control].joyMin = (int)udMin.Value;
			Interface.ActiveDevices[device].controls[control].trainMax = (float)udTMax.Value;
			Interface.ActiveDevices[device].controls[control].trainMin = (float)udTMin.Value;
			Interface.ActiveDevices[device].controls[control].tsid = lsBxControl.SelectedIndex;
			Close();
		}

		private void ControlDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			previewActive = false;
		}

		private void updateLocks()
		{
			btnSave.Enabled = tbName.Text != "" && comboAxis.SelectedIndex >= 0 && lsBxControl.SelectedIndex >= 0;
		}
	}
}
