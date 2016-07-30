namespace ConfuserExStringReader
{
	partial class frmMain
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
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txtAssembly = new System.Windows.Forms.TextBox();
			this.btnRead = new System.Windows.Forms.Button();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMethodName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(444, 30);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(93, 23);
			this.btnSelectFile.TabIndex = 0;
			this.btnSelectFile.Text = "Select Assembly";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txtAssembly
			// 
			this.txtAssembly.Location = new System.Drawing.Point(6, 32);
			this.txtAssembly.Name = "txtAssembly";
			this.txtAssembly.Size = new System.Drawing.Size(432, 20);
			this.txtAssembly.TabIndex = 1;
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(456, 156);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(90, 30);
			this.btnRead.TabIndex = 2;
			this.btnRead.Text = "Read Strings";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// txtClassName
			// 
			this.txtClassName.Location = new System.Drawing.Point(6, 106);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.Size = new System.Drawing.Size(207, 20);
			this.txtClassName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Assembly File:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Main string decryption class full name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "(e.g: namespaceXYZ.classNameXYZ)";
			// 
			// txtMethodName
			// 
			this.txtMethodName.Location = new System.Drawing.Point(231, 106);
			this.txtMethodName.Name = "txtMethodName";
			this.txtMethodName.Size = new System.Drawing.Size(207, 20);
			this.txtMethodName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(228, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "(e.g: methodNameXYZ)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(228, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "String decryptor method name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSelectFile);
			this.groupBox1.Controls.Add(this.txtAssembly);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtClassName);
			this.groupBox1.Controls.Add(this.txtMethodName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(545, 138);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// chkIgnoreEmpty
			// 
			this.chkIgnoreEmpty.AutoSize = true;
			this.chkIgnoreEmpty.Location = new System.Drawing.Point(18, 156);
			this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
			this.chkIgnoreEmpty.Size = new System.Drawing.Size(120, 17);
			this.chkIgnoreEmpty.TabIndex = 10;
			this.chkIgnoreEmpty.Text = "Ignore empty strings";
			this.chkIgnoreEmpty.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 194);
			this.Controls.Add(this.chkIgnoreEmpty);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "ConfuserEx Strings Reader (by SalaR)";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtAssembly;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.TextBox txtClassName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMethodName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkIgnoreEmpty;
	}
}

