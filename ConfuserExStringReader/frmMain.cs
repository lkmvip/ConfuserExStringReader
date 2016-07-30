using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConfuserExStringReader
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Text += " V" + Assembly.GetExecutingAssembly().GetName().Version;
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			using (var o = new OpenFileDialog())
			{
				o.Filter = ".NET|*.exe;*.dll";
				o.CheckFileExists = true;
				if (o.ShowDialog(this) == DialogResult.OK)
				{
					txtAssembly.Text = o.FileName;
				}
			}
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			txtAssembly.Text = txtAssembly.Text.Trim();
			txtClassName.Text = txtClassName.Text.Trim();
			txtMethodName.Text = txtMethodName.Text.Trim();

			if (txtAssembly.Text.Length == 0 ||
				txtClassName.Text.Length == 0 ||
				txtMethodName.Text.Length == 0)
			{
				MessageBox.Show("Please input all the fields.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			btnRead.Enabled = false;
			Application.DoEvents();
			try
			{
				ReadStrings();
			}
			finally
			{
				btnRead.Enabled = true;
			}

		}

		void ReadStrings()
		{
			try
			{
				var assembly = Assembly.LoadFile(txtAssembly.Text);
				var classEx = assembly.GetType(txtClassName.Text, false, true);
				if (classEx == null)
				{
					MessageBox.Show("Class not found, " + txtClassName.Text, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var methodInfo = classEx.GetMethod(txtMethodName.Text, BindingFlags.Default | BindingFlags.NonPublic | BindingFlags.Static);
				if (methodInfo == null)
				{
					MessageBox.Show("Method not found, " + txtMethodName.Text, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var ignoreEmpty = chkIgnoreEmpty.Checked;
				var errorsCount = 0;
				var codeNum = -1;

				var result = new Dictionary<int, object>();
				do
				{
					codeNum++;

					try
					{
						var value = methodInfo.Invoke(null, new object[] {codeNum});
						if (ignoreEmpty && (value as string) == "")
							continue;

						result.Add(codeNum, value);
					}
					catch (Exception)
					{
						errorsCount++;
					}


				} while (errorsCount <= 10);

				var resultStr = JsonConvert.SerializeObject(result, Formatting.Indented);

				var resultFileName = txtAssembly.Text + ".Codes.txt";
				File.WriteAllText(resultFileName, resultStr);

				MessageBox.Show(result.Count + " strings are read from ConfuserEx'ed assembly", "Success", MessageBoxButtons.OK,
					MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Operations failed, " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

	}
}
