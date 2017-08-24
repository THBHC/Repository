using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AirtightDetection
{
	public partial class ParameterSettingsDialog : Form
	{
		public ParameterSettingsDialog()
		{
			InitializeComponent();
		}

		private void txtInflationTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		}

		private void txtAlarmPressure_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == '-');
		}

		private void txtBalanceTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtEquivalentVolume_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtDetectionTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtStartDelayTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtExhaustTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtDifferentialPressureJudgmentValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtLeakRate_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtDirectPressureJudgmentValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtDetectionDelayTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtDifferentialPressureCorrectionValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void btnJudgmentMode_Click(object sender, EventArgs e)
		{
			if (btnJudgmentMode.BackColor == Color.FromArgb(255, 224, 192))
			{
				btnJudgmentMode.BackColor = Color.Blue;
				lblJudgmentMode.Text = "泄漏率判断";
				lblJudgmentMode.Location = new Point(25, 41);
			}
			else
			{
				btnJudgmentMode.BackColor = Color.FromArgb(255, 224, 192);
				lblJudgmentMode.Text = "差压判断";
				lblJudgmentMode.Location = new Point(42, 41);
			}
		}

		private void btnPressureDetectionType_Click(object sender, EventArgs e)
		{
			if (btnPressureDetectionType.BackColor == Color.FromArgb(255, 224, 192))
			{
				btnPressureDetectionType.BackColor = Color.Blue;
				lblPressureDetectionType.Text = "直压式";
			}
			else
			{
				btnPressureDetectionType.BackColor = Color.FromArgb(255, 224, 192);
				lblPressureDetectionType.Text = "差压式";
			}
		}

		private void btnPressureSourceType_Click(object sender, EventArgs e)
		{
			if (btnPressureSourceType.BackColor == Color.FromArgb(255, 224, 192))
			{
				btnPressureSourceType.BackColor = Color.Blue;
				lblPressureSourceType.Text = "负压";
			}
			else
			{
				btnPressureSourceType.BackColor = Color.FromArgb(255, 224, 192);
				lblPressureSourceType.Text = "正压";
			}
		}

		private void ParameterSettingsDialog_Load(object sender, EventArgs e)
		{
			txtInflationTime.Text = Properties.Settings.Default.txtInflationTime;
			txtBalanceTime.Text = Properties.Settings.Default.txtBalanceTime;
			txtDetectionTime.Text = Properties.Settings.Default.txtDetectionTime;
			txtExhaustTime.Text = Properties.Settings.Default.txtExhaustTime;
			txtAlarmPressure.Text = Properties.Settings.Default.txtAlarmPressure;
			txtEquivalentVolume.Text = Properties.Settings.Default.txtEquivalentVolume;
			txtStartDelayTime.Text = Properties.Settings.Default.txtStartDelayTime;
			lblJudgmentMode.Text = Properties.Settings.Default.lblJudgmentMode;
			lblJudgmentMode.Location = Properties.Settings.Default.lblJudgmentModeLocation;
			lblPressureDetectionType.Text = Properties.Settings.Default.lblPressureDetectionType;
			lblPressureSourceType.Text = Properties.Settings.Default.lblPressureSourceType;
			btnJudgmentMode.BackColor = Properties.Settings.Default.btnJudgmentModeBackColor;
			btnPressureDetectionType.BackColor = Properties.Settings.Default.btnPressureDetectionTypeBackColor;
			btnPressureSourceType.BackColor = Properties.Settings.Default.btnPressureSourceTypeBackColor;
			txtDifferentialPressureJudgmentValue.Text = Properties.Settings.Default.txtDifferentialPressureJudgmentValue;
			txtLeakRate.Text = Properties.Settings.Default.txtLeakRate;
			txtDirectPressureJudgmentValue.Text = Properties.Settings.Default.txtDirectPressureJudgmentValue;
			txtPassword.Text = Properties.Settings.Default.txtPassword;
			txtDetectionDelayTime.Text = Properties.Settings.Default.txtDetectionDelayTime;
			txtDifferentialPressureCorrectionValue.Text = Properties.Settings.Default.txtDifferentialPressureCorrectionValue;
			cbxSerialPort1.SelectedIndex = cbxSerialPort1.FindString(Properties.Settings.Default.cbxSerialPort1);
			cbxBaudRate1.SelectedIndex = cbxBaudRate1.FindString(Convert.ToString(Properties.Settings.Default.cbxBaudRate1));
			cbxDataBits1.SelectedIndex = cbxDataBits1.FindString(Convert.ToString(Properties.Settings.Default.cbxDataBits1));
			cbxParity1.SelectedIndex = cbxParity1.FindString(Properties.Settings.Default.cbxParity1.ToString());
			cbxStopBit1.SelectedIndex = cbxStopBit1.FindString(Properties.Settings.Default.cbxStopBit1.ToString());
			cbxSerialPort2.SelectedIndex = cbxSerialPort2.FindString(Properties.Settings.Default.cbxSerialPort2);
			cbxBaudRate2.SelectedIndex = cbxBaudRate2.FindString(Convert.ToString(Properties.Settings.Default.cbxBaudRate2));
			cbxDataBits2.SelectedIndex = cbxDataBits2.FindString(Convert.ToString(Properties.Settings.Default.cbxDataBits2));
			cbxParity2.SelectedIndex = cbxParity2.FindString(Properties.Settings.Default.cbxParity2.ToString());
			cbxStopBit2.SelectedIndex = cbxStopBit2.FindString(Properties.Settings.Default.cbxStopBit2.ToString());
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.txtInflationTime = txtInflationTime.Text;
			Properties.Settings.Default.txtBalanceTime = txtBalanceTime.Text;
			Properties.Settings.Default.txtDetectionTime = txtDetectionTime.Text;
			Properties.Settings.Default.txtExhaustTime = txtExhaustTime.Text;
			Properties.Settings.Default.txtAlarmPressure = txtAlarmPressure.Text;
			Properties.Settings.Default.txtEquivalentVolume = txtEquivalentVolume.Text;
			Properties.Settings.Default.txtStartDelayTime = txtStartDelayTime.Text;
			Properties.Settings.Default.lblJudgmentMode = lblJudgmentMode.Text;
			Properties.Settings.Default.lblJudgmentModeLocation = lblJudgmentMode.Location;
			Properties.Settings.Default.lblPressureDetectionType = lblPressureDetectionType.Text;
			Properties.Settings.Default.lblPressureSourceType = lblPressureSourceType.Text;
			Properties.Settings.Default.btnJudgmentModeBackColor = btnJudgmentMode.BackColor;
			Properties.Settings.Default.btnPressureDetectionTypeBackColor = btnPressureDetectionType.BackColor;
			Properties.Settings.Default.btnPressureSourceTypeBackColor = btnPressureSourceType.BackColor;
			Properties.Settings.Default.txtDifferentialPressureJudgmentValue = txtDifferentialPressureJudgmentValue.Text;
			Properties.Settings.Default.txtLeakRate = txtLeakRate.Text;
			Properties.Settings.Default.txtDirectPressureJudgmentValue = txtDirectPressureJudgmentValue.Text;
			Properties.Settings.Default.txtPassword = txtPassword.Text;
			Properties.Settings.Default.txtDetectionDelayTime = txtDetectionDelayTime.Text;
			Properties.Settings.Default.txtDifferentialPressureCorrectionValue = txtDifferentialPressureCorrectionValue.Text;
			Properties.Settings.Default.cbxSerialPort1 = cbxSerialPort1.Text;
			Properties.Settings.Default.cbxBaudRate1 = Convert.ToInt32(cbxBaudRate1.Text);
			Properties.Settings.Default.cbxDataBits1 = Convert.ToInt32(cbxDataBits1.Text);
			switch (cbxParity1.SelectedIndex)
			{
				case 0:
					Properties.Settings.Default.cbxParity1 = Parity.None;
					break;
				case 1:
					Properties.Settings.Default.cbxParity1 = Parity.Odd;
					break;
				case 2:
					Properties.Settings.Default.cbxParity1 = Parity.Even;
					break;
				case 3:
					Properties.Settings.Default.cbxParity1 = Parity.Mark;
					break;
				case 4:
					Properties.Settings.Default.cbxParity1 = Parity.Space;
					break;
			}
			switch (cbxStopBit1.SelectedIndex)
			{
				case 0:
					Properties.Settings.Default.cbxStopBit1 = StopBits.One;
					break;
				case 1:
					Properties.Settings.Default.cbxStopBit1 = StopBits.OnePointFive;
					break;
				case 2:
					Properties.Settings.Default.cbxStopBit1 = StopBits.Two;
					break;
			}

			Properties.Settings.Default.cbxSerialPort2 = cbxSerialPort2.Text;
			Properties.Settings.Default.cbxBaudRate2 = Convert.ToInt32(cbxBaudRate2.Text);
			Properties.Settings.Default.cbxDataBits2 = Convert.ToInt32(cbxDataBits2.Text);
			switch (cbxParity2.SelectedIndex)
			{
				case 0:
					Properties.Settings.Default.cbxParity2 = Parity.None;
					break;
				case 1:
					Properties.Settings.Default.cbxParity2 = Parity.Odd;
					break;
				case 2:
					Properties.Settings.Default.cbxParity2 = Parity.Even;
					break;
				case 3:
					Properties.Settings.Default.cbxParity2 = Parity.Mark;
					break;
				case 4:
					Properties.Settings.Default.cbxParity2 = Parity.Space;
					break;
			}
			switch (cbxStopBit2.SelectedIndex)
			{
				case 0:
					Properties.Settings.Default.cbxStopBit2 = StopBits.One;
					break;
				case 1:
					Properties.Settings.Default.cbxStopBit2 = StopBits.OnePointFive;
					break;
				case 2:
					Properties.Settings.Default.cbxStopBit2 = StopBits.Two;
					break;
			}

			Properties.Settings.Default.Save();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

	}
}
