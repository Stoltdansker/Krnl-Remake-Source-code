namespace Krnl_remake
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002A4C File Offset: 0x00000C4C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A84 File Offset: 0x00000C84
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Editor = new System.Windows.Forms.WebBrowser();
            this.options = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.execute = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Label();
            this.unc = new System.Windows.Forms.Label();
            this.vulner = new System.Windows.Forms.Label();
            this.infyield = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.visualStudioTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Krnl Remake";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // visualStudioTabControl1
            // 
            this.visualStudioTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.visualStudioTabControl1.AllowDrop = true;
            this.visualStudioTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.visualStudioTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualStudioTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.visualStudioTabControl1.ClosingMessage = null;
            this.visualStudioTabControl1.Controls.Add(this.tabPage1);
            this.visualStudioTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(250, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(-2, 48);
            this.visualStudioTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(669, 339);
            this.visualStudioTabControl1.TabIndex = 3;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.White;
            this.visualStudioTabControl1.SelectedIndexChanged += new System.EventHandler(this.visualStudioTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.Editor);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(661, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "welcome.lua";
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(0, 0);
            this.Editor.MinimumSize = new System.Drawing.Size(20, 20);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(658, 311);
            this.Editor.TabIndex = 0;
            this.Editor.Url = new System.Uri("Leaked By Ditzel", System.UriKind.Relative);
            this.Editor.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Editor_DocumentCompleted_1);
            // 
            // options
            // 
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Location = new System.Drawing.Point(684, 392);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(120, 39);
            this.options.TabIndex = 23;
            this.options.Text = "OPTIONS";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // inject
            // 
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inject.ForeColor = System.Drawing.Color.White;
            this.inject.Location = new System.Drawing.Point(502, 391);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(120, 39);
            this.inject.TabIndex = 22;
            this.inject.Text = "INJECT";
            this.inject.UseVisualStyleBackColor = true;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(378, 391);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 39);
            this.save.TabIndex = 21;
            this.save.Text = "SAVE FILE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.Color.White;
            this.open.Location = new System.Drawing.Point(254, 391);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(120, 39);
            this.open.TabIndex = 20;
            this.open.Text = "OPEN FILE";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click_1);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(129, 391);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 39);
            this.clear.TabIndex = 19;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // execute
            // 
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(4, 391);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(120, 39);
            this.execute.TabIndex = 18;
            this.execute.Text = "EXECUTE";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(645, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(18, 18);
            this.button5.TabIndex = 25;
            this.button5.Text = "+";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(628, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(14, 18);
            this.button6.TabIndex = 26;
            this.button6.Text = "-";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // unc
            // 
            this.unc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unc.ForeColor = System.Drawing.Color.White;
            this.unc.Location = new System.Drawing.Point(667, 54);
            this.unc.Name = "unc";
            this.unc.Size = new System.Drawing.Size(140, 20);
            this.unc.TabIndex = 27;
            this.unc.Text = "UNC.LUA";
            this.unc.Click += new System.EventHandler(this.label2_Click);
            // 
            // vulner
            // 
            this.vulner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.vulner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vulner.ForeColor = System.Drawing.Color.White;
            this.vulner.Location = new System.Drawing.Point(667, 75);
            this.vulner.Name = "vulner";
            this.vulner.Size = new System.Drawing.Size(140, 20);
            this.vulner.TabIndex = 28;
            this.vulner.Text = "VULNER.LUA";
            this.vulner.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // infyield
            // 
            this.infyield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.infyield.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infyield.ForeColor = System.Drawing.Color.White;
            this.infyield.Location = new System.Drawing.Point(667, 96);
            this.infyield.Name = "infyield";
            this.infyield.Size = new System.Drawing.Size(140, 20);
            this.infyield.TabIndex = 29;
            this.infyield.Text = "INFINITE YIELD.LUA";
            this.infyield.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(780, 15);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 30;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(760, 13);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(15, 20);
            this.minimize.TabIndex = 31;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pictureBox3.Location = new System.Drawing.Point(666, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 334);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox2.Location = new System.Drawing.Point(-39, 385);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1004, 72);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Krnl_remake.Properties.Resources.idk__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Krnl_remake.Properties.Resources.idk__1_;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(-2, -1);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(37, 36);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(810, 435);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.infyield);
            this.Controls.Add(this.vulner);
            this.Controls.Add(this.unc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.options);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visualStudioTabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Krnl Remake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.visualStudioTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox logo;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.WebBrowser Editor;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button options;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button inject;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button save;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button open;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button clear;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button execute;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label button5;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label button6;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label unc;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label vulner;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label infyield;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label close;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label minimize;
	}
}
