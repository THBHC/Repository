namespace AirtightDetection
{
	partial class MainWindow
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
			this.components = new System.ComponentModel.Container();
			this.chkChannel1 = new System.Windows.Forms.CheckBox();
			this.chkChannel2 = new System.Windows.Forms.CheckBox();
			this.chkChannel3 = new System.Windows.Forms.CheckBox();
			this.chkChannel4 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.prgChannel1 = new System.Windows.Forms.ProgressBar();
			this.prgChannel2 = new System.Windows.Forms.ProgressBar();
			this.prgChannel3 = new System.Windows.Forms.ProgressBar();
			this.prgChannel4 = new System.Windows.Forms.ProgressBar();
			this.txtChannel1Pressure = new System.Windows.Forms.TextBox();
			this.txtChannel2Pressure = new System.Windows.Forms.TextBox();
			this.txtChannel3Pressure = new System.Windows.Forms.TextBox();
			this.txtChannel4Pressure = new System.Windows.Forms.TextBox();
			this.txtChannel1DifferentPressureValue = new System.Windows.Forms.TextBox();
			this.txtChannel2DifferentPressureValue = new System.Windows.Forms.TextBox();
			this.txtChannel3DifferentPressureValue = new System.Windows.Forms.TextBox();
			this.txtChannel4DifferentPressureValue = new System.Windows.Forms.TextBox();
			this.txtChannel1LeakRate = new System.Windows.Forms.TextBox();
			this.txtChannel2LeakRate = new System.Windows.Forms.TextBox();
			this.txtChannel3LeakRate = new System.Windows.Forms.TextBox();
			this.txtChannel4LeakRate = new System.Windows.Forms.TextBox();
			this.txtChannel1PassQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel2PassQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel3PassQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel4PassQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel1NGQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel2NGQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel3NGQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel4NGQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel1TotalQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel2TotalQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel3TotalQuantity = new System.Windows.Forms.TextBox();
			this.txtChannel4TotalQuantity = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnChannel1Clear = new System.Windows.Forms.Button();
			this.btnChannel2Clear = new System.Windows.Forms.Button();
			this.btnChannel3Clear = new System.Windows.Forms.Button();
			this.btnChannel4Clear = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.tmrWait = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorkerScan = new System.ComponentModel.BackgroundWorker();
			this.lblChannel1Result = new System.Windows.Forms.Label();
			this.lblChannel2Result = new System.Windows.Forms.Label();
			this.lblChannel3Result = new System.Windows.Forms.Label();
			this.lblChannel4Result = new System.Windows.Forms.Label();
			this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
			this.backgroundSaver = new System.ComponentModel.BackgroundWorker();
			this.lblAlarm = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkChannel1
			// 
			this.chkChannel1.AutoSize = true;
			this.chkChannel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.chkChannel1.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkChannel1.ForeColor = System.Drawing.Color.White;
			this.chkChannel1.Location = new System.Drawing.Point(43, 67);
			this.chkChannel1.Name = "chkChannel1";
			this.chkChannel1.Size = new System.Drawing.Size(70, 22);
			this.chkChannel1.TabIndex = 0;
			this.chkChannel1.Text = "通道1";
			this.chkChannel1.UseVisualStyleBackColor = false;
			this.chkChannel1.CheckedChanged += new System.EventHandler(this.chkChannel1_CheckedChanged);
			// 
			// chkChannel2
			// 
			this.chkChannel2.AutoSize = true;
			this.chkChannel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.chkChannel2.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkChannel2.ForeColor = System.Drawing.Color.White;
			this.chkChannel2.Location = new System.Drawing.Point(43, 109);
			this.chkChannel2.Name = "chkChannel2";
			this.chkChannel2.Size = new System.Drawing.Size(70, 22);
			this.chkChannel2.TabIndex = 0;
			this.chkChannel2.Text = "通道2";
			this.chkChannel2.UseVisualStyleBackColor = false;
			this.chkChannel2.CheckedChanged += new System.EventHandler(this.chkChannel2_CheckedChanged);
			// 
			// chkChannel3
			// 
			this.chkChannel3.AutoSize = true;
			this.chkChannel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.chkChannel3.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkChannel3.ForeColor = System.Drawing.Color.White;
			this.chkChannel3.Location = new System.Drawing.Point(43, 151);
			this.chkChannel3.Name = "chkChannel3";
			this.chkChannel3.Size = new System.Drawing.Size(70, 22);
			this.chkChannel3.TabIndex = 0;
			this.chkChannel3.Text = "通道3";
			this.chkChannel3.UseVisualStyleBackColor = false;
			this.chkChannel3.CheckedChanged += new System.EventHandler(this.chkChannel3_CheckedChanged);
			// 
			// chkChannel4
			// 
			this.chkChannel4.AutoSize = true;
			this.chkChannel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.chkChannel4.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkChannel4.ForeColor = System.Drawing.Color.White;
			this.chkChannel4.Location = new System.Drawing.Point(43, 193);
			this.chkChannel4.Name = "chkChannel4";
			this.chkChannel4.Size = new System.Drawing.Size(70, 22);
			this.chkChannel4.TabIndex = 0;
			this.chkChannel4.Text = "通道4";
			this.chkChannel4.UseVisualStyleBackColor = false;
			this.chkChannel4.CheckedChanged += new System.EventHandler(this.chkChannel4_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label1.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(40, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "通道选择";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// prgChannel1
			// 
			this.prgChannel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.prgChannel1.Location = new System.Drawing.Point(116, 67);
			this.prgChannel1.Name = "prgChannel1";
			this.prgChannel1.Size = new System.Drawing.Size(160, 23);
			this.prgChannel1.TabIndex = 2;
			// 
			// prgChannel2
			// 
			this.prgChannel2.Location = new System.Drawing.Point(116, 109);
			this.prgChannel2.Name = "prgChannel2";
			this.prgChannel2.Size = new System.Drawing.Size(160, 23);
			this.prgChannel2.TabIndex = 2;
			// 
			// prgChannel3
			// 
			this.prgChannel3.Location = new System.Drawing.Point(116, 151);
			this.prgChannel3.Name = "prgChannel3";
			this.prgChannel3.Size = new System.Drawing.Size(160, 23);
			this.prgChannel3.TabIndex = 2;
			// 
			// prgChannel4
			// 
			this.prgChannel4.Location = new System.Drawing.Point(116, 193);
			this.prgChannel4.Name = "prgChannel4";
			this.prgChannel4.Size = new System.Drawing.Size(160, 23);
			this.prgChannel4.TabIndex = 2;
			// 
			// txtChannel1Pressure
			// 
			this.txtChannel1Pressure.BackColor = System.Drawing.Color.White;
			this.txtChannel1Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1Pressure.Location = new System.Drawing.Point(282, 65);
			this.txtChannel1Pressure.Name = "txtChannel1Pressure";
			this.txtChannel1Pressure.ReadOnly = true;
			this.txtChannel1Pressure.Size = new System.Drawing.Size(67, 26);
			this.txtChannel1Pressure.TabIndex = 3;
			// 
			// txtChannel2Pressure
			// 
			this.txtChannel2Pressure.BackColor = System.Drawing.Color.White;
			this.txtChannel2Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2Pressure.Location = new System.Drawing.Point(282, 107);
			this.txtChannel2Pressure.Name = "txtChannel2Pressure";
			this.txtChannel2Pressure.ReadOnly = true;
			this.txtChannel2Pressure.Size = new System.Drawing.Size(67, 26);
			this.txtChannel2Pressure.TabIndex = 3;
			// 
			// txtChannel3Pressure
			// 
			this.txtChannel3Pressure.BackColor = System.Drawing.Color.White;
			this.txtChannel3Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3Pressure.Location = new System.Drawing.Point(282, 149);
			this.txtChannel3Pressure.Name = "txtChannel3Pressure";
			this.txtChannel3Pressure.ReadOnly = true;
			this.txtChannel3Pressure.Size = new System.Drawing.Size(67, 26);
			this.txtChannel3Pressure.TabIndex = 3;
			// 
			// txtChannel4Pressure
			// 
			this.txtChannel4Pressure.BackColor = System.Drawing.Color.White;
			this.txtChannel4Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4Pressure.Location = new System.Drawing.Point(282, 191);
			this.txtChannel4Pressure.Name = "txtChannel4Pressure";
			this.txtChannel4Pressure.ReadOnly = true;
			this.txtChannel4Pressure.Size = new System.Drawing.Size(67, 26);
			this.txtChannel4Pressure.TabIndex = 3;
			// 
			// txtChannel1DifferentPressureValue
			// 
			this.txtChannel1DifferentPressureValue.BackColor = System.Drawing.Color.White;
			this.txtChannel1DifferentPressureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1DifferentPressureValue.Location = new System.Drawing.Point(355, 65);
			this.txtChannel1DifferentPressureValue.Name = "txtChannel1DifferentPressureValue";
			this.txtChannel1DifferentPressureValue.ReadOnly = true;
			this.txtChannel1DifferentPressureValue.Size = new System.Drawing.Size(81, 26);
			this.txtChannel1DifferentPressureValue.TabIndex = 3;
			// 
			// txtChannel2DifferentPressureValue
			// 
			this.txtChannel2DifferentPressureValue.BackColor = System.Drawing.Color.White;
			this.txtChannel2DifferentPressureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2DifferentPressureValue.Location = new System.Drawing.Point(355, 107);
			this.txtChannel2DifferentPressureValue.Name = "txtChannel2DifferentPressureValue";
			this.txtChannel2DifferentPressureValue.ReadOnly = true;
			this.txtChannel2DifferentPressureValue.Size = new System.Drawing.Size(81, 26);
			this.txtChannel2DifferentPressureValue.TabIndex = 3;
			// 
			// txtChannel3DifferentPressureValue
			// 
			this.txtChannel3DifferentPressureValue.BackColor = System.Drawing.Color.White;
			this.txtChannel3DifferentPressureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3DifferentPressureValue.Location = new System.Drawing.Point(355, 149);
			this.txtChannel3DifferentPressureValue.Name = "txtChannel3DifferentPressureValue";
			this.txtChannel3DifferentPressureValue.ReadOnly = true;
			this.txtChannel3DifferentPressureValue.Size = new System.Drawing.Size(81, 26);
			this.txtChannel3DifferentPressureValue.TabIndex = 3;
			// 
			// txtChannel4DifferentPressureValue
			// 
			this.txtChannel4DifferentPressureValue.BackColor = System.Drawing.Color.White;
			this.txtChannel4DifferentPressureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4DifferentPressureValue.Location = new System.Drawing.Point(355, 191);
			this.txtChannel4DifferentPressureValue.Name = "txtChannel4DifferentPressureValue";
			this.txtChannel4DifferentPressureValue.ReadOnly = true;
			this.txtChannel4DifferentPressureValue.Size = new System.Drawing.Size(81, 26);
			this.txtChannel4DifferentPressureValue.TabIndex = 3;
			// 
			// txtChannel1LeakRate
			// 
			this.txtChannel1LeakRate.BackColor = System.Drawing.Color.White;
			this.txtChannel1LeakRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1LeakRate.Location = new System.Drawing.Point(442, 65);
			this.txtChannel1LeakRate.Name = "txtChannel1LeakRate";
			this.txtChannel1LeakRate.ReadOnly = true;
			this.txtChannel1LeakRate.Size = new System.Drawing.Size(110, 26);
			this.txtChannel1LeakRate.TabIndex = 3;
			// 
			// txtChannel2LeakRate
			// 
			this.txtChannel2LeakRate.BackColor = System.Drawing.Color.White;
			this.txtChannel2LeakRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2LeakRate.Location = new System.Drawing.Point(442, 107);
			this.txtChannel2LeakRate.Name = "txtChannel2LeakRate";
			this.txtChannel2LeakRate.ReadOnly = true;
			this.txtChannel2LeakRate.Size = new System.Drawing.Size(110, 26);
			this.txtChannel2LeakRate.TabIndex = 3;
			// 
			// txtChannel3LeakRate
			// 
			this.txtChannel3LeakRate.BackColor = System.Drawing.Color.White;
			this.txtChannel3LeakRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3LeakRate.Location = new System.Drawing.Point(442, 149);
			this.txtChannel3LeakRate.Name = "txtChannel3LeakRate";
			this.txtChannel3LeakRate.ReadOnly = true;
			this.txtChannel3LeakRate.Size = new System.Drawing.Size(110, 26);
			this.txtChannel3LeakRate.TabIndex = 3;
			// 
			// txtChannel4LeakRate
			// 
			this.txtChannel4LeakRate.BackColor = System.Drawing.Color.White;
			this.txtChannel4LeakRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4LeakRate.Location = new System.Drawing.Point(442, 191);
			this.txtChannel4LeakRate.Name = "txtChannel4LeakRate";
			this.txtChannel4LeakRate.ReadOnly = true;
			this.txtChannel4LeakRate.Size = new System.Drawing.Size(110, 26);
			this.txtChannel4LeakRate.TabIndex = 3;
			// 
			// txtChannel1PassQuantity
			// 
			this.txtChannel1PassQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel1PassQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1PassQuantity.ForeColor = System.Drawing.Color.Lime;
			this.txtChannel1PassQuantity.Location = new System.Drawing.Point(558, 65);
			this.txtChannel1PassQuantity.Name = "txtChannel1PassQuantity";
			this.txtChannel1PassQuantity.ReadOnly = true;
			this.txtChannel1PassQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel1PassQuantity.TabIndex = 3;
			// 
			// txtChannel2PassQuantity
			// 
			this.txtChannel2PassQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel2PassQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2PassQuantity.ForeColor = System.Drawing.Color.Lime;
			this.txtChannel2PassQuantity.Location = new System.Drawing.Point(558, 107);
			this.txtChannel2PassQuantity.Name = "txtChannel2PassQuantity";
			this.txtChannel2PassQuantity.ReadOnly = true;
			this.txtChannel2PassQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel2PassQuantity.TabIndex = 3;
			// 
			// txtChannel3PassQuantity
			// 
			this.txtChannel3PassQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel3PassQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3PassQuantity.ForeColor = System.Drawing.Color.Lime;
			this.txtChannel3PassQuantity.Location = new System.Drawing.Point(558, 149);
			this.txtChannel3PassQuantity.Name = "txtChannel3PassQuantity";
			this.txtChannel3PassQuantity.ReadOnly = true;
			this.txtChannel3PassQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel3PassQuantity.TabIndex = 3;
			// 
			// txtChannel4PassQuantity
			// 
			this.txtChannel4PassQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel4PassQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4PassQuantity.ForeColor = System.Drawing.Color.Lime;
			this.txtChannel4PassQuantity.Location = new System.Drawing.Point(558, 191);
			this.txtChannel4PassQuantity.Name = "txtChannel4PassQuantity";
			this.txtChannel4PassQuantity.ReadOnly = true;
			this.txtChannel4PassQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel4PassQuantity.TabIndex = 3;
			// 
			// txtChannel1NGQuantity
			// 
			this.txtChannel1NGQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel1NGQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1NGQuantity.ForeColor = System.Drawing.Color.Red;
			this.txtChannel1NGQuantity.Location = new System.Drawing.Point(621, 65);
			this.txtChannel1NGQuantity.Name = "txtChannel1NGQuantity";
			this.txtChannel1NGQuantity.ReadOnly = true;
			this.txtChannel1NGQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel1NGQuantity.TabIndex = 3;
			// 
			// txtChannel2NGQuantity
			// 
			this.txtChannel2NGQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel2NGQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2NGQuantity.ForeColor = System.Drawing.Color.Red;
			this.txtChannel2NGQuantity.Location = new System.Drawing.Point(621, 107);
			this.txtChannel2NGQuantity.Name = "txtChannel2NGQuantity";
			this.txtChannel2NGQuantity.ReadOnly = true;
			this.txtChannel2NGQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel2NGQuantity.TabIndex = 3;
			// 
			// txtChannel3NGQuantity
			// 
			this.txtChannel3NGQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel3NGQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3NGQuantity.ForeColor = System.Drawing.Color.Red;
			this.txtChannel3NGQuantity.Location = new System.Drawing.Point(621, 149);
			this.txtChannel3NGQuantity.Name = "txtChannel3NGQuantity";
			this.txtChannel3NGQuantity.ReadOnly = true;
			this.txtChannel3NGQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel3NGQuantity.TabIndex = 3;
			// 
			// txtChannel4NGQuantity
			// 
			this.txtChannel4NGQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel4NGQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4NGQuantity.ForeColor = System.Drawing.Color.Red;
			this.txtChannel4NGQuantity.Location = new System.Drawing.Point(621, 191);
			this.txtChannel4NGQuantity.Name = "txtChannel4NGQuantity";
			this.txtChannel4NGQuantity.ReadOnly = true;
			this.txtChannel4NGQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel4NGQuantity.TabIndex = 3;
			// 
			// txtChannel1TotalQuantity
			// 
			this.txtChannel1TotalQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel1TotalQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel1TotalQuantity.Location = new System.Drawing.Point(684, 65);
			this.txtChannel1TotalQuantity.Name = "txtChannel1TotalQuantity";
			this.txtChannel1TotalQuantity.ReadOnly = true;
			this.txtChannel1TotalQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel1TotalQuantity.TabIndex = 3;
			// 
			// txtChannel2TotalQuantity
			// 
			this.txtChannel2TotalQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel2TotalQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel2TotalQuantity.Location = new System.Drawing.Point(684, 107);
			this.txtChannel2TotalQuantity.Name = "txtChannel2TotalQuantity";
			this.txtChannel2TotalQuantity.ReadOnly = true;
			this.txtChannel2TotalQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel2TotalQuantity.TabIndex = 3;
			// 
			// txtChannel3TotalQuantity
			// 
			this.txtChannel3TotalQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel3TotalQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel3TotalQuantity.Location = new System.Drawing.Point(684, 149);
			this.txtChannel3TotalQuantity.Name = "txtChannel3TotalQuantity";
			this.txtChannel3TotalQuantity.ReadOnly = true;
			this.txtChannel3TotalQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel3TotalQuantity.TabIndex = 3;
			// 
			// txtChannel4TotalQuantity
			// 
			this.txtChannel4TotalQuantity.BackColor = System.Drawing.Color.White;
			this.txtChannel4TotalQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChannel4TotalQuantity.Location = new System.Drawing.Point(684, 191);
			this.txtChannel4TotalQuantity.Name = "txtChannel4TotalQuantity";
			this.txtChannel4TotalQuantity.ReadOnly = true;
			this.txtChannel4TotalQuantity.Size = new System.Drawing.Size(57, 26);
			this.txtChannel4TotalQuantity.TabIndex = 3;
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnStart.Font = new System.Drawing.Font("STSong", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(52, 282);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(119, 57);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "启 动";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnStop.Font = new System.Drawing.Font("STSong", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Location = new System.Drawing.Point(206, 282);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(119, 57);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "停 止";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnSettings.Font = new System.Drawing.Font("STSong", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSettings.Location = new System.Drawing.Point(702, 282);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(119, 57);
			this.btnSettings.TabIndex = 6;
			this.btnSettings.Text = "设 置";
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label2.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(158, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "测试进度";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label3.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(565, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "合格";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label4.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(620, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "不合格";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label5.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(691, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "总数";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label6.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(281, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 18);
			this.label6.TabIndex = 11;
			this.label6.Text = "压力kPa";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label7.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(357, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "差压值Pa";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.label8.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(441, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 18);
			this.label8.TabIndex = 13;
			this.label8.Text = "泄露率ml/min";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnChannel1Clear
			// 
			this.btnChannel1Clear.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChannel1Clear.Location = new System.Drawing.Point(747, 64);
			this.btnChannel1Clear.Name = "btnChannel1Clear";
			this.btnChannel1Clear.Size = new System.Drawing.Size(77, 28);
			this.btnChannel1Clear.TabIndex = 14;
			this.btnChannel1Clear.Text = "清 零";
			this.btnChannel1Clear.UseVisualStyleBackColor = true;
			this.btnChannel1Clear.Click += new System.EventHandler(this.btnChannel1Clear_Click);
			// 
			// btnChannel2Clear
			// 
			this.btnChannel2Clear.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChannel2Clear.Location = new System.Drawing.Point(747, 106);
			this.btnChannel2Clear.Name = "btnChannel2Clear";
			this.btnChannel2Clear.Size = new System.Drawing.Size(77, 28);
			this.btnChannel2Clear.TabIndex = 14;
			this.btnChannel2Clear.Text = "清 零";
			this.btnChannel2Clear.UseVisualStyleBackColor = true;
			this.btnChannel2Clear.Click += new System.EventHandler(this.btnChannel2Clear_Click);
			// 
			// btnChannel3Clear
			// 
			this.btnChannel3Clear.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChannel3Clear.Location = new System.Drawing.Point(747, 148);
			this.btnChannel3Clear.Name = "btnChannel3Clear";
			this.btnChannel3Clear.Size = new System.Drawing.Size(77, 28);
			this.btnChannel3Clear.TabIndex = 14;
			this.btnChannel3Clear.Text = "清 零";
			this.btnChannel3Clear.UseVisualStyleBackColor = true;
			this.btnChannel3Clear.Click += new System.EventHandler(this.btnChannel3Clear_Click);
			// 
			// btnChannel4Clear
			// 
			this.btnChannel4Clear.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChannel4Clear.Location = new System.Drawing.Point(747, 190);
			this.btnChannel4Clear.Name = "btnChannel4Clear";
			this.btnChannel4Clear.Size = new System.Drawing.Size(77, 28);
			this.btnChannel4Clear.TabIndex = 14;
			this.btnChannel4Clear.Text = "清 零";
			this.btnChannel4Clear.UseVisualStyleBackColor = true;
			this.btnChannel4Clear.Click += new System.EventHandler(this.btnChannel4Clear_Click);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// tmrWait
			// 
			this.tmrWait.Interval = 250;
			this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
			// 
			// backgroundWorkerScan
			// 
			this.backgroundWorkerScan.WorkerSupportsCancellation = true;
			this.backgroundWorkerScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerScan_DoWork);
			// 
			// lblChannel1Result
			// 
			this.lblChannel1Result.AutoSize = true;
			this.lblChannel1Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
			this.lblChannel1Result.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChannel1Result.ForeColor = System.Drawing.Color.Red;
			this.lblChannel1Result.Location = new System.Drawing.Point(178, 67);
			this.lblChannel1Result.Name = "lblChannel1Result";
			this.lblChannel1Result.Size = new System.Drawing.Size(36, 23);
			this.lblChannel1Result.TabIndex = 15;
			this.lblChannel1Result.Text = "NG";
			this.lblChannel1Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblChannel1Result.Visible = false;
			// 
			// lblChannel2Result
			// 
			this.lblChannel2Result.AutoSize = true;
			this.lblChannel2Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
			this.lblChannel2Result.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChannel2Result.ForeColor = System.Drawing.Color.Red;
			this.lblChannel2Result.Location = new System.Drawing.Point(178, 109);
			this.lblChannel2Result.Name = "lblChannel2Result";
			this.lblChannel2Result.Size = new System.Drawing.Size(36, 23);
			this.lblChannel2Result.TabIndex = 15;
			this.lblChannel2Result.Text = "NG";
			this.lblChannel2Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblChannel2Result.Visible = false;
			// 
			// lblChannel3Result
			// 
			this.lblChannel3Result.AutoSize = true;
			this.lblChannel3Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
			this.lblChannel3Result.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChannel3Result.ForeColor = System.Drawing.Color.Red;
			this.lblChannel3Result.Location = new System.Drawing.Point(178, 151);
			this.lblChannel3Result.Name = "lblChannel3Result";
			this.lblChannel3Result.Size = new System.Drawing.Size(36, 23);
			this.lblChannel3Result.TabIndex = 15;
			this.lblChannel3Result.Text = "NG";
			this.lblChannel3Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblChannel3Result.Visible = false;
			// 
			// lblChannel4Result
			// 
			this.lblChannel4Result.AutoSize = true;
			this.lblChannel4Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(40)))));
			this.lblChannel4Result.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChannel4Result.ForeColor = System.Drawing.Color.Red;
			this.lblChannel4Result.Location = new System.Drawing.Point(178, 193);
			this.lblChannel4Result.Name = "lblChannel4Result";
			this.lblChannel4Result.Size = new System.Drawing.Size(36, 23);
			this.lblChannel4Result.TabIndex = 15;
			this.lblChannel4Result.Text = "NG";
			this.lblChannel4Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblChannel4Result.Visible = false;
			// 
			// backgroundSaver
			// 
			this.backgroundSaver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSaver_DoWork);
			// 
			// lblAlarm
			// 
			this.lblAlarm.AutoSize = true;
			this.lblAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(127)))), ((int)(((byte)(217)))));
			this.lblAlarm.Font = new System.Drawing.Font("STSong", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlarm.ForeColor = System.Drawing.Color.Red;
			this.lblAlarm.Location = new System.Drawing.Point(329, 232);
			this.lblAlarm.Name = "lblAlarm";
			this.lblAlarm.Size = new System.Drawing.Size(89, 39);
			this.lblAlarm.TabIndex = 16;
			this.lblAlarm.Text = "报警";
			this.lblAlarm.Visible = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(202)))));
			this.BackgroundImage = global::AirtightDetection.Properties.Resources.Untitled_2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(842, 357);
			this.Controls.Add(this.lblAlarm);
			this.Controls.Add(this.lblChannel4Result);
			this.Controls.Add(this.lblChannel3Result);
			this.Controls.Add(this.lblChannel2Result);
			this.Controls.Add(this.lblChannel1Result);
			this.Controls.Add(this.btnChannel4Clear);
			this.Controls.Add(this.btnChannel3Clear);
			this.Controls.Add(this.btnChannel2Clear);
			this.Controls.Add(this.btnChannel1Clear);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtChannel4TotalQuantity);
			this.Controls.Add(this.txtChannel4NGQuantity);
			this.Controls.Add(this.txtChannel4PassQuantity);
			this.Controls.Add(this.txtChannel4LeakRate);
			this.Controls.Add(this.txtChannel4DifferentPressureValue);
			this.Controls.Add(this.txtChannel4Pressure);
			this.Controls.Add(this.txtChannel3TotalQuantity);
			this.Controls.Add(this.txtChannel3NGQuantity);
			this.Controls.Add(this.txtChannel3PassQuantity);
			this.Controls.Add(this.txtChannel3LeakRate);
			this.Controls.Add(this.txtChannel3DifferentPressureValue);
			this.Controls.Add(this.txtChannel3Pressure);
			this.Controls.Add(this.txtChannel2TotalQuantity);
			this.Controls.Add(this.txtChannel2NGQuantity);
			this.Controls.Add(this.txtChannel2PassQuantity);
			this.Controls.Add(this.txtChannel2LeakRate);
			this.Controls.Add(this.txtChannel2DifferentPressureValue);
			this.Controls.Add(this.txtChannel2Pressure);
			this.Controls.Add(this.txtChannel1TotalQuantity);
			this.Controls.Add(this.txtChannel1NGQuantity);
			this.Controls.Add(this.txtChannel1PassQuantity);
			this.Controls.Add(this.txtChannel1LeakRate);
			this.Controls.Add(this.txtChannel1DifferentPressureValue);
			this.Controls.Add(this.txtChannel1Pressure);
			this.Controls.Add(this.prgChannel4);
			this.Controls.Add(this.prgChannel3);
			this.Controls.Add(this.prgChannel2);
			this.Controls.Add(this.prgChannel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkChannel4);
			this.Controls.Add(this.chkChannel3);
			this.Controls.Add(this.chkChannel2);
			this.Controls.Add(this.chkChannel1);
			this.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.Text = "气密检测仪";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.frmMainWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkChannel1;
		private System.Windows.Forms.CheckBox chkChannel2;
		private System.Windows.Forms.CheckBox chkChannel3;
		private System.Windows.Forms.CheckBox chkChannel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar prgChannel1;
		private System.Windows.Forms.ProgressBar prgChannel2;
		private System.Windows.Forms.ProgressBar prgChannel3;
		private System.Windows.Forms.ProgressBar prgChannel4;
		private System.Windows.Forms.TextBox txtChannel1Pressure;
		private System.Windows.Forms.TextBox txtChannel2Pressure;
		private System.Windows.Forms.TextBox txtChannel3Pressure;
		private System.Windows.Forms.TextBox txtChannel4Pressure;
		private System.Windows.Forms.TextBox txtChannel1DifferentPressureValue;
		private System.Windows.Forms.TextBox txtChannel2DifferentPressureValue;
		private System.Windows.Forms.TextBox txtChannel3DifferentPressureValue;
		private System.Windows.Forms.TextBox txtChannel4DifferentPressureValue;
		private System.Windows.Forms.TextBox txtChannel1LeakRate;
		private System.Windows.Forms.TextBox txtChannel2LeakRate;
		private System.Windows.Forms.TextBox txtChannel3LeakRate;
		private System.Windows.Forms.TextBox txtChannel4LeakRate;
		private System.Windows.Forms.TextBox txtChannel1PassQuantity;
		private System.Windows.Forms.TextBox txtChannel2PassQuantity;
		private System.Windows.Forms.TextBox txtChannel3PassQuantity;
		private System.Windows.Forms.TextBox txtChannel4PassQuantity;
		private System.Windows.Forms.TextBox txtChannel1NGQuantity;
		private System.Windows.Forms.TextBox txtChannel2NGQuantity;
		private System.Windows.Forms.TextBox txtChannel3NGQuantity;
		private System.Windows.Forms.TextBox txtChannel4NGQuantity;
		private System.Windows.Forms.TextBox txtChannel1TotalQuantity;
		private System.Windows.Forms.TextBox txtChannel2TotalQuantity;
		private System.Windows.Forms.TextBox txtChannel3TotalQuantity;
		private System.Windows.Forms.TextBox txtChannel4TotalQuantity;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnChannel1Clear;
		private System.Windows.Forms.Button btnChannel2Clear;
		private System.Windows.Forms.Button btnChannel3Clear;
		private System.Windows.Forms.Button btnChannel4Clear;
		private System.Windows.Forms.Timer tmrWait;
		private System.ComponentModel.BackgroundWorker backgroundWorkerScan;
		private System.Windows.Forms.Label lblChannel1Result;
		private System.Windows.Forms.Label lblChannel2Result;
		private System.Windows.Forms.Label lblChannel3Result;
		private System.Windows.Forms.Label lblChannel4Result;
		private System.ComponentModel.BackgroundWorker backgroundSaver;
		private System.Windows.Forms.Label lblAlarm;
		public System.IO.Ports.SerialPort serialPort1;
		public System.IO.Ports.SerialPort serialPort2;
	}
}

