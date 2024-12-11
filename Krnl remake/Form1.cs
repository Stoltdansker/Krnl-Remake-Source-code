using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using ForlornApi;
using Krnl_remake.Properties;
using VisualStudioTabControl;

namespace Krnl_remake
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public Form1()
		{
			base.MouseDown += this.Form_MouseDown;
			base.MouseMove += this.Form_MouseMove;
			this.time.Tick += this.timertick;
			this.time.Start();
			this.InitializeComponent();
			this.ApplyRoundedCorners(this.execute, 1);
			this.ApplyRoundedCorners(this.inject, 1);
			this.ApplyRoundedCorners(this.open, 1);
			this.ApplyRoundedCorners(this.save, 1);
			this.ApplyRoundedCorners(this.clear, 1);
			this.ApplyRoundedCorners(this.options, 1);
			this.button5.Click -= this.button5_Click;
			this.button5.Click += this.button5_Click;
			this.button6.Click -= this.button6_Click;
			this.button6.Click += this.button6_Click;
			this.clear.Click -= this.clear_Click;
			this.clear.Click += this.clear_Click;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021AB File Offset: 0x000003AB
		private void timertick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021AE File Offset: 0x000003AE
		private void Form_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021CC File Offset: 0x000003CC
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

		// Token: 0x06000005 RID: 5 RVA: 0x0000221C File Offset: 0x0000041C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle rect = base.ClientRectangle;
			int cornerRadius = 1;
			using (GraphicsPath path = new GraphicsPath())
			{
				path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180f, 90f);
				path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270f, 90f);
				path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0f, 90f);
				path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90f, 90f);
				path.CloseFigure();
				base.Region = new Region(path);
				g.SetClip(path, CombineMode.Replace);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002318 File Offset: 0x00000518
		private void ApplyRoundedCorners(Button button, int cornerRadius)
		{
			button.Paint += delegate(object sender, PaintEventArgs paintEventArgs)
			{
				Graphics g = paintEventArgs.Graphics;
				g.SmoothingMode = SmoothingMode.HighQuality;
				Rectangle rect = button.ClientRectangle;
				using (GraphicsPath path = new GraphicsPath())
				{
					path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180f, 90f);
					path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270f, 90f);
					path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0f, 90f);
					path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90f, 90f);
					path.CloseFigure();
					button.Region = new Region(path);
					using (Pen pen = new Pen(button.BackColor, 4f))
					{
						pen.LineJoin = LineJoin.Round;
						pen.StartCap = LineCap.Round;
						pen.EndCap = LineCap.Round;
						g.DrawPath(pen, path);
					}
				}
			};
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002352 File Offset: 0x00000552
		private void logo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002355 File Offset: 0x00000555
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Editor.Navigate(new Uri(string.Format("file:///{0}/Monaco/index.html", Directory.GetCurrentDirectory())));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002378 File Offset: 0x00000578
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000237B File Offset: 0x0000057B
		private void Editor_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000237E File Offset: 0x0000057E
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002381 File Offset: 0x00000581
		private void open_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002384 File Offset: 0x00000584
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002387 File Offset: 0x00000587
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000238C File Offset: 0x0000058C
		private void clear_Click(object sender, EventArgs e)
		{
			bool flag = this.visualStudioTabControl1.SelectedTab != null;
			if (flag)
			{
				foreach (object obj in this.visualStudioTabControl1.SelectedTab.Controls)
				{
					Control control = (Control)obj;
					WebBrowser editor = control as WebBrowser;
					bool flag2 = editor != null && editor.Document != null;
					if (flag2)
					{
						editor.Document.InvokeScript("clearEditor");
					}
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002438 File Offset: 0x00000638
		private void save_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
				DefaultExt = "txt",
				Title = "Save Lua or Text File"
			};
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					bool flag2 = this.visualStudioTabControl1.SelectedTab != null;
					if (flag2)
					{
						WebBrowser editor = this.visualStudioTabControl1.SelectedTab.Controls[0] as WebBrowser;
						bool flag3 = editor != null && editor.Document != null;
						if (flag3)
						{
							editor.Document.InvokeScript("transferValueToHiddenInput");
							HtmlElement hiddenInput = editor.Document.GetElementById("hiddenInput");
							string editorContent = ((hiddenInput != null) ? hiddenInput.GetAttribute("value") : null) ?? string.Empty;
							bool flag4 = !string.IsNullOrEmpty(editorContent);
							if (flag4)
							{
								using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
								{
									writer.Write(editorContent);
								}
								bool flag5 = File.Exists(saveFileDialog.FileName);
								if (flag5)
								{
									string fileContent = File.ReadAllText(saveFileDialog.FileName);
									editor.Document.InvokeScript("setValue", new object[] { fileContent });
								}
								else
								{
									MessageBox.Show("File not found: " + saveFileDialog.FileName);
								}
							}
							else
							{
								MessageBox.Show("Editor content is empty.");
							}
						}
						else
						{
							MessageBox.Show("No editor found in the selected tab.");
						}
					}
					else
					{
						MessageBox.Show("No tab is currently selected.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002628 File Offset: 0x00000828
		private void open_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
				DefaultExt = "txt",
				Title = "Open Lua or Text File"
			};
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					string fileContent = File.ReadAllText(openFileDialog.FileName);
					bool flag2 = this.visualStudioTabControl1.SelectedTab != null;
					if (flag2)
					{
						WebBrowser editor = this.visualStudioTabControl1.SelectedTab.Controls[0] as WebBrowser;
						bool flag3 = editor != null && editor.Document != null;
						if (flag3)
						{
							editor.Document.InvokeScript("setValue", new object[] { fileContent });
						}
						else
						{
							MessageBox.Show("No editor found in the selected tab.");
						}
					}
					else
					{
						MessageBox.Show("No tab is currently selected.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002738 File Offset: 0x00000938
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://slat.cc/Ditzel");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002746 File Offset: 0x00000946
		private void button5_Click(object sender, EventArgs e)
		{
			this.AddNewTab(null);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002754 File Offset: 0x00000954
		private void button6_Click(object sender, EventArgs e)
		{
			bool flag = this.visualStudioTabControl1.TabPages.Count > 1;
			if (flag)
			{
				TabPage selectedTab = this.visualStudioTabControl1.SelectedTab;
				bool flag2 = selectedTab != null;
				if (flag2)
				{
					this.visualStudioTabControl1.TabPages.Remove(selectedTab);
					this.tabCount--;
				}
			}
			else
			{
				MessageBox.Show("You need at least 2 tabs to remove one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027C8 File Offset: 0x000009C8
		private void AddNewTab(string tabName = null)
		{
			this.tabCount++;
			string tabTitle = tabName ?? string.Format("Script {0}.lua", this.tabCount);
			TabPage newTab = new TabPage(tabTitle);
			WebBrowser editor = new WebBrowser
			{
				Dock = DockStyle.Fill,
				Name = "Editor" + this.tabCount.ToString()
			};
			string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string htmlFilePath = Path.Combine(appDirectory, "Monaco", "index.html");
			bool flag = File.Exists(htmlFilePath);
			if (flag)
			{
				editor.Navigate(new Uri("file:///" + htmlFilePath));
			}
			else
			{
				MessageBox.Show("HTML file not found: " + htmlFilePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			newTab.Controls.Add(editor);
			this.visualStudioTabControl1.TabPages.Add(newTab);
			this.visualStudioTabControl1.SelectedTab = newTab;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000028C0 File Offset: 0x00000AC0
		private void execute_Click(object sender, EventArgs e)
		{
			bool flag = this.visualStudioTabControl1.SelectedTab != null;
			if (flag)
			{
				WebBrowser editor = this.visualStudioTabControl1.SelectedTab.Controls[0] as WebBrowser;
				bool flag2 = editor != null && editor.Document != null;
				if (flag2)
				{
					string script = editor.Document.InvokeScript("getValue").ToString();
					Api.ExecuteScript(script);
					bool flag3 = Api.IsInjected();
					if (!flag3)
					{
						MessageBox.Show("Krnl remake is not injected, please attach first to execute. Error 800");
					}
				}
				else
				{
					MessageBox.Show("No editor found in the selected tab.");
				}
			}
			else
			{
				MessageBox.Show("No tab is currently selected.");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002970 File Offset: 0x00000B70
		private void inject_Click(object sender, EventArgs e)
		{
			Api.Inject();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000297C File Offset: 0x00000B7C
		private void label2_Click(object sender, EventArgs e)
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				Api.ExecuteScript("loadstring(game:HttpGet('https://github.com/ltseverydayyou/uuuuuuu/blob/main/UNC%20test?raw=true'))()");
			}
			else
			{
				MessageBox.Show("Please inject first.");
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000029B0 File Offset: 0x00000BB0
		private void label2_Click_1(object sender, EventArgs e)
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				Api.ExecuteScript("loadstring(game:HttpGet('https://github.com/radmehrmc/vulnerabillity/raw/refs/heads/main/vulnerabillity.txt'))()");
			}
			else
			{
				MessageBox.Show("Please inject first.");
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029E4 File Offset: 0x00000BE4
		private void label2_Click_2(object sender, EventArgs e)
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				Api.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
			}
			else
			{
				MessageBox.Show("Please inject first.");
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A18 File Offset: 0x00000C18
		private void options_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(this);
			form2.Show();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002A34 File Offset: 0x00000C34
		private void visualStudioTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A37 File Offset: 0x00000C37
		private void minimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002A42 File Offset: 0x00000C42
		private void close_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000001 RID: 1
		private int tabCount = 0;

		// Token: 0x04000002 RID: 2
		private Timer time = new Timer();

		// Token: 0x04000003 RID: 3
		public Point mouseLocation;
	}
}
