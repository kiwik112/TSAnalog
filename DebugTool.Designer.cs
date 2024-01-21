namespace TSAnalog
{
	partial class DebugTool
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			timer1 = new System.Windows.Forms.Timer(components);
			listBox1 = new ListBox();
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(412, 424);
			listBox1.TabIndex = 0;
			// 
			// DebugTool
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(436, 450);
			Controls.Add(listBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "DebugTool";
			Text = "DebugTool";
			FormClosing += DebugTool_FormClosing;
			Load += DebugTool_Load;
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private ListBox listBox1;
	}
}