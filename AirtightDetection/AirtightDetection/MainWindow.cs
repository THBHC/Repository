using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace AirtightDetection
{
	public partial class MainWindow : Form
	{
		bool serialPort1Status = false;
		bool serialPort2Status = false;
		bool IsAllChannelOk = false;
		int CurrentDetectChannel = 0; // 0: All selected channel is detecting. 1: channel 1 is detecting.
		Int32 TotalWaitTime = 0; // Wait the total time. Total Wait Time = inflation time + balance time + detection time + delay time.
		Int32 InflationWaitTime = 0; // Wait the inflation time. Inflation Wait Time = inflation time.
		Int32 BalanceWaitTime = 0; // Wait the balance time. Balance Wait Time = inflation time + balance time.

		Int32 Counter = 0;
		static AutoResetEvent mEvent = new AutoResetEvent(false);
		static AutoResetEvent nEvent = new AutoResetEvent(false);
		string str; // Serial port 1 received string.

		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Read parameters from configuration file, and download data to lower computer.
		/// </summary>
		private void ReadParameterAndDownload()
		{
			serialPort1.PortName = Properties.Settings.Default.cbxSerialPort1;
			serialPort2.PortName = Properties.Settings.Default.cbxSerialPort2;

			if (serialPort1.IsOpen) // serial port 1 has opened.
			{
				MessageBox.Show("连接仪器的串口已经被占用，请更改串口。", "打开串口出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// Download data.
				backgroundSaver.RunWorkerAsync();
			}

			if (serialPort2.IsOpen) // serial port 2 has opened.
			{
				MessageBox.Show("连接扫描器的串口已经被占用，请更改串口。", "打开串口出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				serialPort2.BaudRate = Properties.Settings.Default.cbxBaudRate2;
				serialPort2.DataBits = Properties.Settings.Default.cbxDataBits2;
				serialPort2.Parity = Properties.Settings.Default.cbxParity2;
				serialPort2.StopBits = Properties.Settings.Default.cbxStopBit2;
				serialPort2.NewLine = "\r\n";
				serialPort2.Open();  
				serialPort2Status = true;
			}

			// Initialize relative variable.
			// Total wait time's unit is 250ms.
			TotalWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime) + Convert.ToInt32(Properties.Settings.Default.txtBalanceTime)
							+ Convert.ToInt32(Properties.Settings.Default.txtDetectionTime) + Convert.ToInt32(Properties.Settings.Default.txtExhaustTime)
							+ Convert.ToInt32(Properties.Settings.Default.txtStartDelayTime)) * 4;
			// Inflation wait time's unit is 250ms.
			InflationWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime)) * 4;
			// Balance wait time's unit is 250ms.
			BalanceWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime) + Convert.ToInt32(Properties.Settings.Default.txtBalanceTime)) * 4;
		}

		/// <summary>
		/// Download 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backgroundSaver_DoWork(object sender, DoWorkEventArgs e)
		{
			SerialPort mySerialPort = new SerialPort();
			mySerialPort.PortName = Properties.Settings.Default.cbxSerialPort1;
			mySerialPort.BaudRate = Properties.Settings.Default.cbxBaudRate1;
			mySerialPort.DataBits = Properties.Settings.Default.cbxDataBits1;
			mySerialPort.Parity = Properties.Settings.Default.cbxParity1;
			mySerialPort.StopBits = Properties.Settings.Default.cbxStopBit1;
			mySerialPort.Open();

			// Download data.
			// Set Inflation Time.
			mySerialPort.Write(string.Format("sft({0})", Properties.Settings.Default.txtInflationTime));
			Thread.Sleep(350);
			// Set Balance Time.
			mySerialPort.Write(string.Format("sbt({0})", Properties.Settings.Default.txtBalanceTime));
			Thread.Sleep(350);
			// Set Detection Time.
			mySerialPort.Write(string.Format("stt({0})", Properties.Settings.Default.txtDetectionTime));
			Thread.Sleep(350);
			// Set Exhaust Time.
			mySerialPort.Write(string.Format("set({0})", Properties.Settings.Default.txtExhaustTime));
			Thread.Sleep(350);
			// Set Alarm Pressure.
			mySerialPort.Write(string.Format("sap({0})", Properties.Settings.Default.txtAlarmPressure));
			Thread.Sleep(350);
			// Set Equivalent Volume.
			mySerialPort.Write(string.Format("sv({0})", Properties.Settings.Default.txtEquivalentVolume));
			Thread.Sleep(350);
			// Set Start Delay Time.
			mySerialPort.Write(string.Format("sds({0})", Properties.Settings.Default.txtStartDelayTime));
			Thread.Sleep(350);
			// Set Judgment Mode.
			if ("差压判断" == Properties.Settings.Default.lblJudgmentMode)
			{
				mySerialPort.Write("sdm(0)");
			}
			else if ("泄漏率判断" == Properties.Settings.Default.lblJudgmentMode)
			{
				mySerialPort.Write("sdm(1)");
			}
			Thread.Sleep(350);

			// Set Pressure Detection Type.
			if ("差压式" == Properties.Settings.Default.lblPressureDetectionType)
			{
				mySerialPort.Write("st(0)");
			}
			else if ("直压式" == Properties.Settings.Default.lblPressureDetectionType)
			{
				mySerialPort.Write("st(1)");
			}
			Thread.Sleep(350);

			// Set Pressure Source Type.
			if ("正压" == Properties.Settings.Default.lblPressureSourceType)
			{
				mySerialPort.Write("ss(0)");
			}
			else if ("负压" == Properties.Settings.Default.lblPressureSourceType)
			{
				mySerialPort.Write("ss(1)");
			}
			Thread.Sleep(350);
			// Set Differential Pressure Judgment Value.
			mySerialPort.Write(string.Format("sdd({0})", Properties.Settings.Default.txtDifferentialPressureJudgmentValue));
			Thread.Sleep(350);
			// Set Leak Rate.
			mySerialPort.Write(string.Format("sld({0})", Properties.Settings.Default.txtLeakRate));
			Thread.Sleep(350);
			// Set Direct Pressure Judgment Value.
			mySerialPort.Write(string.Format("sdpd({0})", Properties.Settings.Default.txtDirectPressureJudgmentValue));
			Thread.Sleep(350);
			mySerialPort.Close();

			// Reopen serialport 1.
			this.Invoke(new EventHandler(ReopenSerialPort));
		}
		private void ReopenSerialPort(object sender, EventArgs e)
		{
			serialPort1.PortName = Properties.Settings.Default.cbxSerialPort1;
			serialPort1.BaudRate = Properties.Settings.Default.cbxBaudRate1;
			serialPort1.DataBits = Properties.Settings.Default.cbxDataBits1;
			serialPort1.Parity = Properties.Settings.Default.cbxParity1;
			serialPort1.StopBits = Properties.Settings.Default.cbxStopBit1;
			serialPort1.Open();
			serialPort1Status = true;

			btnStart.Enabled = true;
			btnStart.BackColor = SystemColors.ControlLight;
		}

		private void frmMainWindow_Load(object sender, EventArgs e)
		{
			// Read Last detection data from configuration file.
			chkChannel1.CheckState = Properties.Settings.Default.chkChannel1;
			chkChannel2.CheckState = Properties.Settings.Default.chkChannel2;
			chkChannel3.CheckState = Properties.Settings.Default.chkChannel3;
			chkChannel4.CheckState = Properties.Settings.Default.chkChannel4;
			txtChannel1PassQuantity.Text = Properties.Settings.Default.txtChannel1PassQuantity;
			txtChannel2PassQuantity.Text = Properties.Settings.Default.txtChannel2PassQuantity;
			txtChannel3PassQuantity.Text = Properties.Settings.Default.txtChannel3PassQuantity;
			txtChannel4PassQuantity.Text = Properties.Settings.Default.txtChannel4PassQuantity;
			txtChannel1NGQuantity.Text = Properties.Settings.Default.txtChannel1NGQuantity;
			txtChannel2NGQuantity.Text = Properties.Settings.Default.txtChannel2NGQuantity;
			txtChannel3NGQuantity.Text = Properties.Settings.Default.txtChannel3NGQuantity;
			txtChannel4NGQuantity.Text = Properties.Settings.Default.txtChannel4NGQuantity;
			txtChannel1TotalQuantity.Text = Properties.Settings.Default.txtChannel1TotalQuantity;
			txtChannel2TotalQuantity.Text = Properties.Settings.Default.txtChannel2TotalQuantity;
			txtChannel3TotalQuantity.Text = Properties.Settings.Default.txtChannel3TotalQuantity;
			txtChannel4TotalQuantity.Text = Properties.Settings.Default.txtChannel4TotalQuantity;

			serialPort1.PortName = Properties.Settings.Default.cbxSerialPort1;
			serialPort2.PortName = Properties.Settings.Default.cbxSerialPort2;

			if (serialPort1.IsOpen) // serial port 1 has opened.
			{
				MessageBox.Show("连接仪器的串口已经被占用，请更改串口。", "打开串口出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				serialPort1.PortName = Properties.Settings.Default.cbxSerialPort1;
				serialPort1.BaudRate = Properties.Settings.Default.cbxBaudRate1;
				serialPort1.DataBits = Properties.Settings.Default.cbxDataBits1;
				serialPort1.Parity = Properties.Settings.Default.cbxParity1;
				serialPort1.StopBits = Properties.Settings.Default.cbxStopBit1;
				serialPort1.Open();
				serialPort1Status = true;
			}

			if (serialPort2.IsOpen) // serial port 2 has opened.
			{
				MessageBox.Show("连接扫描器的串口已经被占用，请更改串口。", "打开串口出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				serialPort2.BaudRate = Properties.Settings.Default.cbxBaudRate2;
				serialPort2.DataBits = Properties.Settings.Default.cbxDataBits2;
				serialPort2.Parity = Properties.Settings.Default.cbxParity2;
				serialPort2.StopBits = Properties.Settings.Default.cbxStopBit2;
				serialPort2.NewLine = "\r\n";
				serialPort2.Open();
				serialPort2Status = true;
			}

			// Initialize relative variable.
			// Total wait time's unit is 250ms.
			TotalWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime) + Convert.ToInt32(Properties.Settings.Default.txtBalanceTime)
							+ Convert.ToInt32(Properties.Settings.Default.txtDetectionTime) + Convert.ToInt32(Properties.Settings.Default.txtExhaustTime)
							+ Convert.ToInt32(Properties.Settings.Default.txtStartDelayTime)) * 4;
			// Inflation wait time's unit is 250ms.
			InflationWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime)) * 4;
			// Balance wait time's unit is 250ms.
			BalanceWaitTime = (Convert.ToInt32(Properties.Settings.Default.txtInflationTime) + Convert.ToInt32(Properties.Settings.Default.txtBalanceTime)) * 4;
		}

		private void btnChannel1Clear_Click(object sender, EventArgs e)
		{
			txtChannel1PassQuantity.Text = Convert.ToString(0);
			txtChannel1NGQuantity.Text = Convert.ToString(0);
			txtChannel1TotalQuantity.Text = Convert.ToString(0);
		}

		private void btnChannel2Clear_Click(object sender, EventArgs e)
		{
			txtChannel2PassQuantity.Text = Convert.ToString(0);
			txtChannel2NGQuantity.Text = Convert.ToString(0);
			txtChannel2TotalQuantity.Text = Convert.ToString(0);
		}

		private void btnChannel3Clear_Click(object sender, EventArgs e)
		{
			txtChannel3PassQuantity.Text = Convert.ToString(0);
			txtChannel3NGQuantity.Text = Convert.ToString(0);
			txtChannel3TotalQuantity.Text = Convert.ToString(0);
		}

		private void btnChannel4Clear_Click(object sender, EventArgs e)
		{
			txtChannel4PassQuantity.Text = Convert.ToString(0);
			txtChannel4NGQuantity.Text = Convert.ToString(0);
			txtChannel4TotalQuantity.Text = Convert.ToString(0);
		}

		private void chkChannel1_CheckedChanged(object sender, EventArgs e)
		{
			if (chkChannel1.CheckState == CheckState.Checked)
			{
				chkChannel1.BackColor = Color.LightGreen;
			}
			else
			{
				chkChannel1.BackColor = Color.FromArgb(1, 112, 202);
				prgChannel1.Value = 0;
				lblChannel1Result.Visible = false;
				txtChannel1Pressure.Text = "";
				txtChannel1DifferentPressureValue.Text = "";
				txtChannel1LeakRate.Text = "";
			}
		}

		private void chkChannel2_CheckedChanged(object sender, EventArgs e)
		{
			if (chkChannel2.CheckState == CheckState.Checked)
			{
				chkChannel2.BackColor = Color.LightGreen;
			}
			else
			{
				chkChannel2.BackColor = Color.FromArgb(1, 112, 202);
				prgChannel2.Value = 0;
				lblChannel2Result.Visible = false;
				txtChannel2Pressure.Text = "";
				txtChannel2DifferentPressureValue.Text = "";
				txtChannel2LeakRate.Text = "";
			}
		}

		private void chkChannel3_CheckedChanged(object sender, EventArgs e)
		{
			if (chkChannel3.CheckState == CheckState.Checked)
			{
				chkChannel3.BackColor = Color.LightGreen;
			}
			else
			{
				chkChannel3.BackColor = Color.FromArgb(1, 112, 202);
				prgChannel3.Value = 0;
				lblChannel3Result.Visible = false;
				txtChannel3Pressure.Text = "";
				txtChannel3DifferentPressureValue.Text = "";
				txtChannel3LeakRate.Text = "";
			}
		}

		private void chkChannel4_CheckedChanged(object sender, EventArgs e)
		{
			if (chkChannel4.CheckState == CheckState.Checked)
			{
				chkChannel4.BackColor = Color.LightGreen;
			}
			else
			{
				chkChannel4.BackColor = Color.FromArgb(1, 112, 202);
				prgChannel4.Value = 0;
				lblChannel4Result.Visible = false;
				txtChannel4Pressure.Text = "";
				txtChannel4DifferentPressureValue.Text = "";
				txtChannel4LeakRate.Text = "";
			}
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			btnStart.Enabled = false;
			btnStart.BackColor = SystemColors.ControlDark;
			LoginDialog frmLogin = new LoginDialog();
			if (DialogResult.OK == frmLogin.ShowDialog())
			{
				ParameterSettingsDialog frmParameterSettings = new ParameterSettingsDialog();
				if (DialogResult.OK == frmParameterSettings.ShowDialog()) // Save parameters.
				{
					// Re-Initialize all parameter, and transmit to lower computer.
					serialPort1.Close(); // Close old serial port.
					serialPort2.Close(); // Close old serial port.

					// Download parameters to lower computer.			
					ReadParameterAndDownload();
				}
				else
				{
					btnStart.Enabled = true;
					btnStart.BackColor = SystemColors.ControlLight;
				}
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (serialPort1Status == true)
			{
				if (serialPort2Status == true)
				{
					if (chkChannel1.CheckState == CheckState.Checked || chkChannel2.CheckState == CheckState.Checked || chkChannel3.CheckState == CheckState.Checked || chkChannel4.CheckState == CheckState.Checked)
					{
						// Reinitialize variable, in case of interrupt by user.
						CurrentDetectChannel = 0; // Clear current detect channel.
						Counter = 0;
						lblChannel1Result.Visible = false;
						lblChannel2Result.Visible = false;
						lblChannel3Result.Visible = false;
						lblChannel4Result.Visible = false;
						prgChannel1.Value = 0;
						prgChannel2.Value = 0;
						prgChannel3.Value = 0;
						prgChannel4.Value = 0;

						if (chkChannel1.CheckState == CheckState.Checked)
						{
							txtChannel1Pressure.Text = "0.0";
							txtChannel1DifferentPressureValue.Text = "0.00";
							txtChannel1LeakRate.Text = "0.00";
						}
						if (chkChannel2.CheckState == CheckState.Checked)
						{
							txtChannel2Pressure.Text = "0.0";
							txtChannel2DifferentPressureValue.Text = "0.00";
							txtChannel2LeakRate.Text = "0.00";
						}
						if (chkChannel3.CheckState == CheckState.Checked)
						{
							txtChannel3Pressure.Text = "0.0";
							txtChannel3DifferentPressureValue.Text = "0.00";
							txtChannel3LeakRate.Text = "0.00";
						}
						if (chkChannel4.CheckState == CheckState.Checked)
						{
							txtChannel4Pressure.Text = "0.0";
							txtChannel4DifferentPressureValue.Text = "0.00";
							txtChannel4LeakRate.Text = "0.00";
						}

						btnStart.BackColor = Color.LightGreen;  // Toggle the start button's back color.
						btnStart.Enabled = false;
						lblAlarm.Visible = false;

						backgroundWorkerScan.RunWorkerAsync();
					}
					else
					{
						MessageBox.Show("请选择通道后，再开始测试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else
				{
					MessageBox.Show("连接扫描器的串口问题未修复，请修复串口后再启动。", "串口未修复", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("连接仪器的串口问题未修复，请修复串口后再启动。", "串口未修复", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			// Stop airtight instrument.
			serialPort1.Write("stop");
			// Stop scan instrument.
			serialPort2.WriteLine("ResetChannelall");
			// Reset btnStart button's back color.
			btnStart.BackColor = SystemColors.ControlLight;
			btnStart.Enabled = true;
			Counter = 0;

			if (backgroundWorkerScan.IsBusy == true)
			{
				backgroundWorkerScan.CancelAsync();
				mEvent.Set();
			}

			tmrWait.Stop();
			if (lblAlarm.Visible == true)
			{
				Thread.Sleep(350);
				serialPort1.Write("leftrun");
				Thread.Sleep(500);
				serialPort1.Write("stop");
			}
		}

		/// <summary>
		/// Save data at the form closing.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			serialPort1.Close();
			serialPort2.Close();

			Properties.Settings.Default.chkChannel1 = chkChannel1.CheckState;
			Properties.Settings.Default.chkChannel2 = chkChannel2.CheckState;
			Properties.Settings.Default.chkChannel3 = chkChannel3.CheckState;
			Properties.Settings.Default.chkChannel4 = chkChannel4.CheckState;
			Properties.Settings.Default.txtChannel1PassQuantity = txtChannel1PassQuantity.Text;
			Properties.Settings.Default.txtChannel2PassQuantity = txtChannel2PassQuantity.Text;
			Properties.Settings.Default.txtChannel3PassQuantity = txtChannel3PassQuantity.Text;
			Properties.Settings.Default.txtChannel4PassQuantity = txtChannel4PassQuantity.Text;
			Properties.Settings.Default.txtChannel1NGQuantity = txtChannel1NGQuantity.Text;
			Properties.Settings.Default.txtChannel2NGQuantity = txtChannel2NGQuantity.Text;
			Properties.Settings.Default.txtChannel3NGQuantity = txtChannel3NGQuantity.Text;
			Properties.Settings.Default.txtChannel4NGQuantity = txtChannel4NGQuantity.Text;
			Properties.Settings.Default.txtChannel1TotalQuantity = txtChannel1TotalQuantity.Text;
			Properties.Settings.Default.txtChannel2TotalQuantity = txtChannel2TotalQuantity.Text;
			Properties.Settings.Default.txtChannel3TotalQuantity = txtChannel3TotalQuantity.Text;
			Properties.Settings.Default.txtChannel4TotalQuantity = txtChannel4TotalQuantity.Text;

			Properties.Settings.Default.Save();
		}

		private void SendStartSignal(object sender, EventArgs e)
		{
			switch (CurrentDetectChannel)
			{
				case 0: // Detect all selected channel.
					if (chkChannel1.CheckState == CheckState.Checked)
						serialPort2.WriteLine("SetChannel0");
					if (chkChannel2.CheckState == CheckState.Checked)
						serialPort2.WriteLine("SetChannel1");
					if (chkChannel3.CheckState == CheckState.Checked)
						serialPort2.WriteLine("SetChannel2");
					if (chkChannel4.CheckState == CheckState.Checked)
						serialPort2.WriteLine("SetChannel3");
					serialPort1.Write("leftrun"); // Airtight running.
					break;
				case 1:
					serialPort2.WriteLine("SetChannel0"); // Open all channel to test.
					Thread.Sleep(500);
					serialPort1.Write("leftrun"); // Airtight running.
					break;
				case 2:
					serialPort2.WriteLine("SetChannel1"); // Open all channel to test.
					Thread.Sleep(500);
					serialPort1.Write("leftrun"); // Airtight running.
					break;
				case 3:
					serialPort2.WriteLine("SetChannel2"); // Open all channel to test.
					Thread.Sleep(500);
					serialPort1.Write("leftrun"); // Airtight running.
					break;
				case 4:
					serialPort2.WriteLine("SetChannel3"); // Open all channel to test.
					Thread.Sleep(500);
					serialPort1.Write("leftrun"); // Airtight running.
					break;
			}
			//serialPort1.Write("leftrun"); // Airtight running.

			Thread.Sleep(2000); // Read last error if no waitment.
			tmrWait.Start(); // Start timer run.
		}
		/// <summary>
		/// Execute a background scan thread.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backgroundWorkerScan_DoWork(object sender, DoWorkEventArgs e)
		{
			for (CurrentDetectChannel = 0; CurrentDetectChannel < 5; CurrentDetectChannel++)
			{
				// Send start signal from rs232.
				this.Invoke(new EventHandler(SendStartSignal));
				Counter = 0;

				mEvent.WaitOne(); // Wait for triggered.
				if (backgroundWorkerScan.CancellationPending == true)
				{
					e.Cancel = true;
					return;
				}

				//Thread.Sleep(2000);

				// Judgment the result and display result.
				this.Invoke(new EventHandler(JudgmentAndDisplayResult));
				nEvent.WaitOne();

				// All selected channel are ok, so end tetect.
				if (CurrentDetectChannel == 0 && IsAllChannelOk == true)
				{
					tmrWait.Stop();
					return;
				}

				// If the next channel is unchecked, so jump it.
				while (++CurrentDetectChannel < 5)
				{
					if (CurrentDetectChannel == 1 && chkChannel1.CheckState == CheckState.Checked)
					{
						CurrentDetectChannel--;
						break;
					}
					if (CurrentDetectChannel == 2 && chkChannel2.CheckState == CheckState.Checked)
					{
						CurrentDetectChannel--;
						break;
					}
					if (CurrentDetectChannel == 3 && chkChannel3.CheckState == CheckState.Checked)
					{
						CurrentDetectChannel--;
						break;
					}
					if (CurrentDetectChannel == 4 && chkChannel4.CheckState == CheckState.Checked)
					{
						CurrentDetectChannel--;
						break;
					}
				}
			}
			this.Invoke(new EventHandler(DetectEnd));
		}

		private void DetectEnd(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnStart.BackColor = SystemColors.ControlLight;
		}

		// Judgment the result and display result.
		private void JudgmentAndDisplayResult(object sender, EventArgs e)
		{
			serialPort1.Write("stop");  // Stop the airtight instrument.

			switch (CurrentDetectChannel)
			{
				case 0: // Detect all channel.
					IsAllChannelOk = true;
					if (chkChannel1.CheckState == CheckState.Checked)
					{
						if (((Convert.ToDouble(txtChannel1DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
							|| (Convert.ToDouble(txtChannel1LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断"))  && (txtChannel1DifferentPressureValue.Text != "999.90") && (txtChannel1LeakRate.Text != "99.99")) 
						{
							lblChannel1Result.Text = "OK";
							lblChannel1Result.ForeColor = Color.Blue;
							lblChannel1Result.Visible = true;
							txtChannel1PassQuantity.Text = (Convert.ToInt32(txtChannel1PassQuantity.Text) + 1).ToString();
							txtChannel1TotalQuantity.Text = (Convert.ToInt32(txtChannel1TotalQuantity.Text) + 1).ToString();
							btnStart.BackColor = SystemColors.ControlLight; // Clear the start button's back color.
							btnStart.Enabled = true;
						}
						else
						{
							prgChannel1.Value = 0;
							txtChannel1Pressure.Text = "0.0";
							txtChannel1DifferentPressureValue.Text = "0.00";
							txtChannel1LeakRate.Text = "0.00";
							IsAllChannelOk = false;
						}
					}
					if (chkChannel2.CheckState == CheckState.Checked)
					{
						if (((Convert.ToDouble(txtChannel2DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
						   || (Convert.ToDouble(txtChannel2LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel2DifferentPressureValue.Text != "999.90") && (txtChannel2LeakRate.Text != "99.99"))
						{
							lblChannel2Result.Text = "OK";
							lblChannel2Result.ForeColor = Color.Blue;
							lblChannel2Result.Visible = true;
							txtChannel2PassQuantity.Text = (Convert.ToInt32(txtChannel2PassQuantity.Text) + 1).ToString();
							txtChannel2TotalQuantity.Text = (Convert.ToInt32(txtChannel2TotalQuantity.Text) + 1).ToString();
							btnStart.BackColor = SystemColors.ControlLight; // Clear the start button's back color.
							btnStart.Enabled = true;
						}
						else
						{
							prgChannel2.Value = 0;
							txtChannel2Pressure.Text = "0.0";
							txtChannel2DifferentPressureValue.Text = "0.00";
							txtChannel2LeakRate.Text = "0.00";
							IsAllChannelOk = false;
						}
					}
					if (chkChannel3.CheckState == CheckState.Checked)
					{
						if (((Convert.ToDouble(txtChannel3DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
							|| (Convert.ToDouble(txtChannel3LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel3DifferentPressureValue.Text != "999.90") && (txtChannel3LeakRate.Text != "99.99"))
						{
							lblChannel3Result.Text = "OK";
							lblChannel3Result.ForeColor = Color.Blue;
							lblChannel3Result.Visible = true;
							txtChannel3PassQuantity.Text = (Convert.ToInt32(txtChannel3PassQuantity.Text) + 1).ToString();
							txtChannel3TotalQuantity.Text = (Convert.ToInt32(txtChannel3TotalQuantity.Text) + 1).ToString();
							btnStart.BackColor = SystemColors.ControlLight; // Clear the start button's back color.
							btnStart.Enabled = true;
						}
						else
						{
							prgChannel3.Value = 0;
							txtChannel3Pressure.Text = "0.0";
							txtChannel3DifferentPressureValue.Text = "0.00";
							txtChannel3LeakRate.Text = "0.00";
							IsAllChannelOk = false;
						}
					}
					if (chkChannel4.CheckState == CheckState.Checked)
					{
						if (((Convert.ToDouble(txtChannel4DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
							|| (Convert.ToDouble(txtChannel4LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel4DifferentPressureValue.Text != "999.90") && (txtChannel4LeakRate.Text != "99.99"))
						{
							lblChannel4Result.Text = "OK";
							lblChannel4Result.ForeColor = Color.Blue;
							lblChannel4Result.Visible = true;
							txtChannel4PassQuantity.Text = (Convert.ToInt32(txtChannel4PassQuantity.Text) + 1).ToString();
							txtChannel4TotalQuantity.Text = (Convert.ToInt32(txtChannel4TotalQuantity.Text) + 1).ToString();
							btnStart.BackColor = SystemColors.ControlLight; // Clear the start button's back color.
							btnStart.Enabled = true;
						}
						else
						{
							prgChannel4.Value = 0;
							txtChannel4Pressure.Text = "0.0";
							txtChannel4DifferentPressureValue.Text = "0.00";
							txtChannel4LeakRate.Text = "0.00";
							IsAllChannelOk = false;
						}
					}
					// Close all selected channel.
					serialPort2.WriteLine("ResetChannelall");
					break;
				case 1: // Detect channel 1.
					if (((Convert.ToDouble(txtChannel1DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
						|| (Convert.ToDouble(txtChannel1LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel1DifferentPressureValue.Text != "999.90") && (txtChannel1LeakRate.Text != "99.99"))
					{
						lblChannel1Result.Text = "OK";
						lblChannel1Result.ForeColor = Color.Blue;
						lblChannel1Result.Visible = true;

						txtChannel1PassQuantity.Text = (Convert.ToInt32(txtChannel1PassQuantity.Text) + 1).ToString();
					}
					else
					{
						lblChannel1Result.Text = "NG";
						lblChannel1Result.ForeColor = Color.Red;
						lblChannel1Result.Visible = true;

						txtChannel1NGQuantity.Text = (Convert.ToInt32(txtChannel1NGQuantity.Text) + 1).ToString();
					}
					txtChannel1TotalQuantity.Text = (Convert.ToInt32(txtChannel1TotalQuantity.Text) + 1).ToString();
					serialPort2.WriteLine("ResetChannel0");
					break;
				case 2: // Detect channel 2.
					if (((Convert.ToDouble(txtChannel2DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
						|| (Convert.ToDouble(txtChannel2LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel2DifferentPressureValue.Text != "999.90") && (txtChannel2LeakRate.Text != "99.99"))
					{
						lblChannel2Result.Text = "OK";
						lblChannel2Result.ForeColor = Color.Blue;
						lblChannel2Result.Visible = true;

						txtChannel2PassQuantity.Text = (Convert.ToInt32(txtChannel2PassQuantity.Text) + 1).ToString();
					}
					else
					{
						lblChannel2Result.Text = "NG";
						lblChannel2Result.ForeColor = Color.Red;
						lblChannel2Result.Visible = true;

						txtChannel2NGQuantity.Text = (Convert.ToInt32(txtChannel2NGQuantity.Text) + 1).ToString();
					}
					txtChannel2TotalQuantity.Text = (Convert.ToInt32(txtChannel2TotalQuantity.Text) + 1).ToString();
					serialPort2.WriteLine("ResetChannel1");
					break;
				case 3: // Detect channel 3.
					if (((Convert.ToDouble(txtChannel3DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
						|| (Convert.ToDouble(txtChannel3LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel3DifferentPressureValue.Text != "999.90") && (txtChannel3LeakRate.Text != "99.99"))
					{
						lblChannel3Result.Text = "OK";
						lblChannel3Result.ForeColor = Color.Blue;
						lblChannel3Result.Visible = true;

						txtChannel3PassQuantity.Text = (Convert.ToInt32(txtChannel3PassQuantity.Text) + 1).ToString();
					}
					else
					{
						lblChannel3Result.Text = "NG";
						lblChannel3Result.ForeColor = Color.Red;
						lblChannel3Result.Visible = true;

						txtChannel3NGQuantity.Text = (Convert.ToInt32(txtChannel3NGQuantity.Text) + 1).ToString();
					}
					txtChannel3TotalQuantity.Text = (Convert.ToInt32(txtChannel3TotalQuantity.Text) + 1).ToString();
					serialPort2.WriteLine("ResetChannel2");
					break;
				case 4: // Detect channel 4.
					if (((Convert.ToDouble(txtChannel4DifferentPressureValue.Text) < Convert.ToInt32(Properties.Settings.Default.txtDifferentialPressureJudgmentValue) && Properties.Settings.Default.lblJudgmentMode == "差压判断")
						|| (Convert.ToDouble(txtChannel4LeakRate.Text) < Convert.ToInt32(Properties.Settings.Default.txtLeakRate) && Properties.Settings.Default.lblJudgmentMode == "泄漏率判断")) && (txtChannel4DifferentPressureValue.Text != "999.90") && (txtChannel4LeakRate.Text != "99.99"))
					{
						lblChannel4Result.Text = "OK";
						lblChannel4Result.ForeColor = Color.Blue;
						lblChannel4Result.Visible = true;

						txtChannel4PassQuantity.Text = (Convert.ToInt32(txtChannel4PassQuantity.Text) + 1).ToString();
					}
					else
					{
						lblChannel4Result.Text = "NG";
						lblChannel4Result.ForeColor = Color.Red;
						lblChannel4Result.Visible = true;

						txtChannel4NGQuantity.Text = (Convert.ToInt32(txtChannel4NGQuantity.Text) + 1).ToString();
					}
					txtChannel4TotalQuantity.Text = (Convert.ToInt32(txtChannel4TotalQuantity.Text) + 1).ToString();
					serialPort2.WriteLine("ResetChannel3");
					break;
			}
			nEvent.Set();
		}

		private void tmrWait_Tick(object sender, EventArgs e)
		{
			if (++Counter == TotalWaitTime)
			{
				switch (CurrentDetectChannel)
				{
					case 0:
						if (chkChannel1.CheckState == CheckState.Checked)
							prgChannel1.Value = 100;
						if (chkChannel2.CheckState == CheckState.Checked)
							prgChannel2.Value = 100;
						if (chkChannel3.CheckState == CheckState.Checked)
							prgChannel3.Value = 100;
						if (chkChannel4.CheckState == CheckState.Checked)
							prgChannel4.Value = 100;
						break;
					case 1:
						prgChannel1.Value = 100;
						break;
					case 2:
						prgChannel2.Value = 100;
						break;
					case 3:
						prgChannel3.Value = 100;
						break;
					case 4:
						prgChannel4.Value = 100;
						break;
				}
				tmrWait.Stop();
				Counter = 0; // Clear counter for next use.
				mEvent.Set(); // Notify the backgroundScan go to work.
			}
			else // Detecting is on the going.
			{
				switch (CurrentDetectChannel)
				{
					case 0:
						if (chkChannel1.CheckState == CheckState.Checked)
							prgChannel1.Value = 100 * Counter / TotalWaitTime;
						if (chkChannel2.CheckState == CheckState.Checked)
							prgChannel2.Value = 100 * Counter / TotalWaitTime;
						if (chkChannel3.CheckState == CheckState.Checked)
							prgChannel3.Value = 100 * Counter / TotalWaitTime;
						if (chkChannel4.CheckState == CheckState.Checked)
							prgChannel4.Value = 100 * Counter / TotalWaitTime;
						break;
					case 1:
						prgChannel1.Value = 100 * Counter / TotalWaitTime;
						break;
					case 2:
						prgChannel2.Value = 100 * Counter / TotalWaitTime;
						break;
					case 3:
						prgChannel3.Value = 100 * Counter / TotalWaitTime;
						break;
					case 4:
						prgChannel4.Value = 100 * Counter / TotalWaitTime;
						break;
					default:
						break;
				}

				// Take turns reading the value.
				switch (Counter % 3)
				{
					case 0:
						serialPort1.Write("presure?");
						break;
					case 1:
						serialPort1.Write("dpresure?");
						break;
					case 2:
						serialPort1.Write("leakage?");
						break;
				}
			}
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			str = serialPort1.ReadExisting();
			this.Invoke(new EventHandler(DisplayData));
		}

		/// <summary>
		/// Display data pressure, differential pressure value, leak rate value.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DisplayData(object sender, EventArgs e)
		{
			if (((Counter % 3) == 1 && str == "999.90") || ((Counter % 3) == 2 && str == "99.99")) // Check for alarms.
			{
				tmrWait.Stop(); // Stop the timer run.
				
				if (Counter < InflationWaitTime) // There is a alarm that air pressure is lower.
				{
					// Stop Detect, because continue to detecting, the alarm always happen.
					lblAlarm.Text = "<报警：气压过低>";
					lblAlarm.Visible = true;

					// Reset btnStart button's back color.
					btnStart.BackColor = SystemColors.ControlDark;

					if (chkChannel1.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 1))
					{
						txtChannel1DifferentPressureValue.Text = "999.90";
						txtChannel1LeakRate.Text = "99.99";
					}
					if (chkChannel2.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 2))
					{
						txtChannel2DifferentPressureValue.Text = "999.90";
						txtChannel2LeakRate.Text = "99.99";
					}
					if (chkChannel3.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 3))
					{
						txtChannel3DifferentPressureValue.Text = "999.90";
						txtChannel3LeakRate.Text = "99.99";
					}
					if (chkChannel4.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 4))
					{
						txtChannel4DifferentPressureValue.Text = "999.90";
						txtChannel4LeakRate.Text = "99.99";
					}
					serialPort2.WriteLine("ResetChannelall");

					backgroundWorkerScan.CancelAsync();	// End the background scan.
					mEvent.Set();
				}
				if (Counter >= InflationWaitTime && Counter < TotalWaitTime) // there is a alarm that leakage is too large.
				{
					if (chkChannel1.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 1))
					{
						txtChannel1DifferentPressureValue.Text = "999.90";
						txtChannel1LeakRate.Text = "99.99";
					}
					if (chkChannel2.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 2))
					{
						txtChannel2DifferentPressureValue.Text = "999.90";
						txtChannel2LeakRate.Text = "99.99";
					}
					if (chkChannel3.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 3))
					{
						txtChannel3DifferentPressureValue.Text = "999.90";
						txtChannel3LeakRate.Text = "99.99";
					}
					if (chkChannel4.CheckState == CheckState.Checked && (CurrentDetectChannel == 0 || CurrentDetectChannel == 4))
					{
						txtChannel4DifferentPressureValue.Text = "999.90";
						txtChannel4LeakRate.Text = "99.99";
					}

					// Continue single channel detect.
					mEvent.Set(); // Notify the backgroundScan go to work.
				}
			}
			else
			{
				switch (CurrentDetectChannel)
				{
					case 0:
						switch (Counter % 3)
						{
							case 0:
								if (chkChannel1.CheckState == CheckState.Checked)
									txtChannel1Pressure.Text = str;
								if (chkChannel2.CheckState == CheckState.Checked)
									txtChannel2Pressure.Text = str;
								if (chkChannel3.CheckState == CheckState.Checked)
									txtChannel3Pressure.Text = str;
								if (chkChannel4.CheckState == CheckState.Checked)
									txtChannel4Pressure.Text = str;
								break;
							case 1:
								if (chkChannel1.CheckState == CheckState.Checked)
									txtChannel1DifferentPressureValue.Text = str;
								if (chkChannel2.CheckState == CheckState.Checked)
									txtChannel2DifferentPressureValue.Text = str;
								if (chkChannel3.CheckState == CheckState.Checked)
									txtChannel3DifferentPressureValue.Text = str;
								if (chkChannel4.CheckState == CheckState.Checked)
									txtChannel4DifferentPressureValue.Text = str;
								break;
							case 2:
								if (chkChannel1.CheckState == CheckState.Checked)
									txtChannel1LeakRate.Text = str;
								if (chkChannel2.CheckState == CheckState.Checked)
									txtChannel2LeakRate.Text = str;
								if (chkChannel3.CheckState == CheckState.Checked)
									txtChannel3LeakRate.Text = str;
								if (chkChannel4.CheckState == CheckState.Checked)
									txtChannel4LeakRate.Text = str;
								break;
						}
						break;
					case 1:
						switch (Counter % 3)
						{
							case 0:
								txtChannel1Pressure.Text = str;
								break;
							case 1:
								txtChannel1DifferentPressureValue.Text = str;
								break;
							case 2:
								txtChannel1LeakRate.Text = str;
								break;
						}
						break;
					case 2:
						switch (Counter % 3)
						{
							case 0:
								txtChannel2Pressure.Text = str;
								break;
							case 1:
								txtChannel2DifferentPressureValue.Text = str;
								break;
							case 2:
								txtChannel2LeakRate.Text = str;
								break;
						}
						break;
					case 3:
						switch (Counter % 3)
						{
							case 0:
								txtChannel3Pressure.Text = str;
								break;
							case 1:
								txtChannel3DifferentPressureValue.Text = str;
								break;
							case 2:
								txtChannel3LeakRate.Text = str;
								break;
						}
						break;
					case 4:
						switch (Counter % 3)
						{
							case 0:
								txtChannel4Pressure.Text = str;
								break;
							case 1:
								txtChannel4DifferentPressureValue.Text = str;
								break;
							case 2:
								txtChannel4LeakRate.Text = str;
								break;
						}
						break;
				}
			}
		}
	}
}
