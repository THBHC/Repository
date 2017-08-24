using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirtightDetection
{
	public partial class LoginDialog : Form
	{
		public LoginDialog()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtPassword.Text == Properties.Settings.Default.txtPassword)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("密码错误，请重新输入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
