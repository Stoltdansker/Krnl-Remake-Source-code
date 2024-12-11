using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Krnl_remake.Properties;

namespace Krnl_remake
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003F68 File Offset: 0x00002168
		public Form2(Form1 mainForm)
		{
			base.MouseDown += this.Form_MouseDown;
			base.MouseMove += this.Form_MouseMove;
			this.InitializeComponent();
			this.form1 = mainForm;
			base.TopMost = true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003FC0 File Offset: 0x000021C0
		private void Form_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003FDC File Offset: 0x000021DC
		private void Form_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePos;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004029 File Offset: 0x00002229
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000402C File Offset: 0x0000222C
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004030 File Offset: 0x00002230
		private void Form2_Load(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.form1.TopMost = true;
				this.form1.BringToFront();
			}
			else
			{
				this.form1.TopMost = false;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004079 File Offset: 0x00002279
		private void minimize2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004084 File Offset: 0x00002284
		private void close2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000408E File Offset: 0x0000228E
		private void topmost_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004091 File Offset: 0x00002291
		private void topmosttext_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004094 File Offset: 0x00002294
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.form1.TopMost = true;
				this.form1.BringToFront();
			}
			else
			{
				this.form1.TopMost = false;
			}
		}

		// Token: 0x0400001A RID: 26
		public Point mouseLocation;

		// Token: 0x0400001B RID: 27
		private Form1 form1;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://slat.cc/Ditzel");
        }
    }
}
