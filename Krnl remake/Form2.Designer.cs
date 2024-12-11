namespace Krnl_remake
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000040E0 File Offset: 0x000022E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004118 File Offset: 0x00002318
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close2 = new System.Windows.Forms.Label();
            this.minimize2 = new System.Windows.Forms.Label();
            this.topmosttext = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Krnl_remake.Properties.Resources.idk__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 47);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(57)))));
            this.pictureBox2.Location = new System.Drawing.Point(-13, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 2);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // close2
            // 
            this.close2.AutoSize = true;
            this.close2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2.ForeColor = System.Drawing.Color.White;
            this.close2.Location = new System.Drawing.Point(416, 14);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(21, 20);
            this.close2.TabIndex = 4;
            this.close2.Text = "X";
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // minimize2
            // 
            this.minimize2.AutoSize = true;
            this.minimize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize2.ForeColor = System.Drawing.Color.White;
            this.minimize2.Location = new System.Drawing.Point(397, 14);
            this.minimize2.Name = "minimize2";
            this.minimize2.Size = new System.Drawing.Size(15, 20);
            this.minimize2.TabIndex = 5;
            this.minimize2.Text = "-";
            this.minimize2.Click += new System.EventHandler(this.minimize2_Click);
            // 
            // topmosttext
            // 
            this.topmosttext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topmosttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topmosttext.ForeColor = System.Drawing.Color.White;
            this.topmosttext.Location = new System.Drawing.Point(6, 85);
            this.topmosttext.Name = "topmosttext";
            this.topmosttext.Size = new System.Drawing.Size(134, 24);
            this.topmosttext.TabIndex = 7;
            this.topmosttext.Text = "TopMost";
            this.topmosttext.Click += new System.EventHandler(this.topmosttext_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(446, 291);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.topmosttext);
            this.Controls.Add(this.minimize2);
            this.Controls.Add(this.close2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label close2;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label minimize2;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label topmosttext;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
