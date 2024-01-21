namespace TSAnalog
{
	public partial class DebugTool : Form
	{
		public DebugTool()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			string[] controls = TS.GetData()[1].Split("::");
			listBox1.BeginUpdate();
			int tempIndex = listBox1.SelectedIndex;
			for (int i = 0; i < controls.Length; i++)
			{
				if (listBox1.Items.Count <= i + 2)
				{
					listBox1.Items.Add(controls[i] + new string(' ', 100 - controls[i].Length) + TS.GetControl(i)[0]);
					continue;
				}
				listBox1.Items.RemoveAt(i + 2);
				listBox1.Items.Insert(i + 2, controls[i] + new string(' ', 100 - controls[i].Length) + TS.GetControl(i)[0]);
			}
			listBox1.SelectedIndex = tempIndex;
			listBox1.EndUpdate();
		}

		private void DebugTool_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
		}

		private void DebugTool_Load(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			listBox1.Items.Add("Control" + new string(' ', 93) + "Value");
			listBox1.Items.Add("");
			timer1.Start();
		}
	}
}
