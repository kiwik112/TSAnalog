namespace TSAnalog
{
	public partial class Controls : Form
	{
		public int device;
		public Controls()
		{
			InitializeComponent();
		}

		private void Controls_Load(object sender, EventArgs e)
		{
			refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Interface.ActiveDevices[device].controls.Add(new Control("Control " + (Interface.ActiveDevices[device].controls.Count() + 1)));
			refresh();
		}

		private void lsBxControls_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lsBxControls.SelectedIndex != -1)
			{
				btnEdit.Enabled = true;
				btnRemove.Enabled = true;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ControlDialog controlDialog = new ControlDialog() { device = device, control = lsBxControls.SelectedIndex };
			controlDialog.ShowDialog();
			refresh();

		}

		private void refresh()
		{
			lsBxControls.Items.Clear();
			foreach (Control control in Interface.ActiveDevices[device].controls)
			{
				lsBxControls.Items.Add(control.name);
			}
		}

		private void updateLocks()
		{
			btnEdit.Enabled = lsBxControls.SelectedIndex >= 0;
			btnRemove.Enabled = lsBxControls.SelectedIndex >= 0;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to remove '" + Interface.ActiveDevices[device].controls[lsBxControls.SelectedIndex].name + "' ?", "", MessageBoxButtons.YesNo);
			if (result == DialogResult.No) return;
			Interface.ActiveDevices[device].controls.RemoveAt(lsBxControls.SelectedIndex);
			refresh();
			updateLocks();
		}
	}
}
