namespace COMServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.savebotton = new System.Windows.Forms.Button();
            this.CLSTxtBoxAllReceive = new System.Windows.Forms.Button();
            this.txtBoxAllReceive = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.State = new System.Windows.Forms.Label();
            this.xrf = new System.Windows.Forms.Button();
            this.adjust_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameter_set = new System.Windows.Forms.GroupBox();
            this.Sample_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Zeroing = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.time_delay = new System.Windows.Forms.DomainUpDown();
            this.start_angle = new System.Windows.Forms.TextBox();
            this.startangle = new System.Windows.Forms.Label();
            this.scan_step = new System.Windows.Forms.DomainUpDown();
            this.scanstep = new System.Windows.Forms.Label();
            this.scan_way = new System.Windows.Forms.ComboBox();
            this.scanway = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.close_motor = new System.Windows.Forms.Button();
            this.scanmodel_txt = new System.Windows.Forms.ComboBox();
            this.scan_speed = new System.Windows.Forms.Label();
            this.run_model = new System.Windows.Forms.Label();
            this.stopangle_txt = new System.Windows.Forms.TextBox();
            this.stop_angle = new System.Windows.Forms.Label();
            this.runmodel_txt = new System.Windows.Forms.ComboBox();
            this.Full_scale = new System.Windows.Forms.TextBox();
            this.Sample_control = new System.Windows.Forms.GroupBox();
            this.Amt = new System.Windows.Forms.Label();
            this.Current_value = new System.Windows.Forms.Label();
            this.Lb_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Open = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Adjust_hight = new System.Windows.Forms.DomainUpDown();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Go = new System.Windows.Forms.Button();
            this.Shaft_model = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Step_width = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Xray_position = new System.Windows.Forms.Label();
            this.collect_position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.off = new System.Windows.Forms.Button();
            this.turnon = new System.Windows.Forms.Button();
            this.stop_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.turn_model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.parameter_set.SuspendLayout();
            this.Sample_control.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.savebotton);
            this.groupBox5.Controls.Add(this.CLSTxtBoxAllReceive);
            this.groupBox5.Controls.Add(this.txtBoxAllReceive);
            this.groupBox5.Location = new System.Drawing.Point(268, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 777);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据接收";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "角度值        强度值";
            // 
            // savebotton
            // 
            this.savebotton.Location = new System.Drawing.Point(133, 16);
            this.savebotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savebotton.Name = "savebotton";
            this.savebotton.Size = new System.Drawing.Size(44, 26);
            this.savebotton.TabIndex = 14;
            this.savebotton.Text = "保存";
            this.savebotton.UseVisualStyleBackColor = true;
            this.savebotton.Click += new System.EventHandler(this.savebotton_Click);
            // 
            // CLSTxtBoxAllReceive
            // 
            this.CLSTxtBoxAllReceive.Location = new System.Drawing.Point(14, 16);
            this.CLSTxtBoxAllReceive.Name = "CLSTxtBoxAllReceive";
            this.CLSTxtBoxAllReceive.Size = new System.Drawing.Size(44, 26);
            this.CLSTxtBoxAllReceive.TabIndex = 1;
            this.CLSTxtBoxAllReceive.Text = "清除\r\n";
            this.CLSTxtBoxAllReceive.UseVisualStyleBackColor = true;
            this.CLSTxtBoxAllReceive.Click += new System.EventHandler(this.CLSTxtBoxAllReceive_Click);
            // 
            // txtBoxAllReceive
            // 
            this.txtBoxAllReceive.AcceptsReturn = true;
            this.txtBoxAllReceive.Location = new System.Drawing.Point(14, 66);
            this.txtBoxAllReceive.Multiline = true;
            this.txtBoxAllReceive.Name = "txtBoxAllReceive";
            this.txtBoxAllReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxAllReceive.Size = new System.Drawing.Size(163, 692);
            this.txtBoxAllReceive.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.State);
            this.groupBox2.Controls.Add(this.xrf);
            this.groupBox2.Controls.Add(this.adjust_button);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 49);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始化";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(113, 30);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(77, 12);
            this.State.TabIndex = 28;
            this.State.Text = "串口通信状态";
            // 
            // xrf
            // 
            this.xrf.Enabled = false;
            this.xrf.Location = new System.Drawing.Point(49, 17);
            this.xrf.Name = "xrf";
            this.xrf.Size = new System.Drawing.Size(62, 26);
            this.xrf.TabIndex = 27;
            this.xrf.Text = "xrf采集";
            this.xrf.UseVisualStyleBackColor = true;
            this.xrf.Click += new System.EventHandler(this.xrf_Click);
            // 
            // adjust_button
            // 
            this.adjust_button.Location = new System.Drawing.Point(7, 17);
            this.adjust_button.Name = "adjust_button";
            this.adjust_button.Size = new System.Drawing.Size(43, 26);
            this.adjust_button.TabIndex = 14;
            this.adjust_button.Text = "校读";
            this.adjust_button.UseVisualStyleBackColor = true;
            this.adjust_button.Click += new System.EventHandler(this.adjust_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // parameter_set
            // 
            this.parameter_set.Controls.Add(this.Sample_name);
            this.parameter_set.Controls.Add(this.label13);
            this.parameter_set.Controls.Add(this.Zeroing);
            this.parameter_set.Controls.Add(this.label14);
            this.parameter_set.Controls.Add(this.label11);
            this.parameter_set.Controls.Add(this.time_delay);
            this.parameter_set.Controls.Add(this.start_angle);
            this.parameter_set.Controls.Add(this.startangle);
            this.parameter_set.Controls.Add(this.scan_step);
            this.parameter_set.Controls.Add(this.scanstep);
            this.parameter_set.Controls.Add(this.scan_way);
            this.parameter_set.Controls.Add(this.scanway);
            this.parameter_set.Controls.Add(this.run_button);
            this.parameter_set.Controls.Add(this.close_motor);
            this.parameter_set.Controls.Add(this.scanmodel_txt);
            this.parameter_set.Controls.Add(this.scan_speed);
            this.parameter_set.Controls.Add(this.run_model);
            this.parameter_set.Controls.Add(this.stopangle_txt);
            this.parameter_set.Controls.Add(this.stop_angle);
            this.parameter_set.Controls.Add(this.runmodel_txt);
            this.parameter_set.Location = new System.Drawing.Point(13, 485);
            this.parameter_set.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parameter_set.Name = "parameter_set";
            this.parameter_set.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parameter_set.Size = new System.Drawing.Size(204, 311);
            this.parameter_set.TabIndex = 26;
            this.parameter_set.TabStop = false;
            this.parameter_set.Text = "XRD扫描参数设置";
            // 
            // Sample_name
            // 
            this.Sample_name.Location = new System.Drawing.Point(82, 258);
            this.Sample_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sample_name.Name = "Sample_name";
            this.Sample_name.Size = new System.Drawing.Size(86, 21);
            this.Sample_name.TabIndex = 30;
            this.Sample_name.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 258);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "样品名：";
            // 
            // Zeroing
            // 
            this.Zeroing.Location = new System.Drawing.Point(82, 224);
            this.Zeroing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zeroing.Name = "Zeroing";
            this.Zeroing.Size = new System.Drawing.Size(88, 21);
            this.Zeroing.TabIndex = 28;
            this.Zeroing.Text = "0";
            this.Zeroing.Leave += new System.EventHandler(this.Zeroing_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "零点调整：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "单动模式θ<50:联动2θ<100";
            // 
            // time_delay
            // 
            this.time_delay.Enabled = false;
            this.time_delay.Location = new System.Drawing.Point(84, 67);
            this.time_delay.Name = "time_delay";
            this.time_delay.Size = new System.Drawing.Size(90, 21);
            this.time_delay.TabIndex = 23;
            this.time_delay.Text = "0.3";
            this.time_delay.Visible = false;
            this.time_delay.SelectedItemChanged += new System.EventHandler(this.time_delay_SelectedItemChanged);
            // 
            // start_angle
            // 
            this.start_angle.Location = new System.Drawing.Point(82, 159);
            this.start_angle.Name = "start_angle";
            this.start_angle.Size = new System.Drawing.Size(90, 21);
            this.start_angle.TabIndex = 22;
            this.start_angle.Text = "0";
            this.start_angle.Leave += new System.EventHandler(this.start_angle_Leave);
            // 
            // startangle
            // 
            this.startangle.AutoSize = true;
            this.startangle.Location = new System.Drawing.Point(10, 166);
            this.startangle.Name = "startangle";
            this.startangle.Size = new System.Drawing.Size(65, 12);
            this.startangle.TabIndex = 21;
            this.startangle.Text = "起始角度：";
            // 
            // scan_step
            // 
            this.scan_step.Location = new System.Drawing.Point(82, 128);
            this.scan_step.Name = "scan_step";
            this.scan_step.Size = new System.Drawing.Size(90, 21);
            this.scan_step.TabIndex = 20;
            this.scan_step.Text = "0.02";
            this.scan_step.SelectedItemChanged += new System.EventHandler(this.scan_step_SelectedItemChanged);
            // 
            // scanstep
            // 
            this.scanstep.AutoSize = true;
            this.scanstep.Location = new System.Drawing.Point(9, 130);
            this.scanstep.Name = "scanstep";
            this.scanstep.Size = new System.Drawing.Size(65, 12);
            this.scanstep.TabIndex = 19;
            this.scanstep.Text = "采样步宽：";
            // 
            // scan_way
            // 
            this.scan_way.FormattingEnabled = true;
            this.scan_way.Items.AddRange(new object[] {
            "连续扫描",
            "定时步进"});
            this.scan_way.Location = new System.Drawing.Point(82, 38);
            this.scan_way.Name = "scan_way";
            this.scan_way.Size = new System.Drawing.Size(90, 20);
            this.scan_way.TabIndex = 18;
            this.scan_way.Text = "连续扫描";
            this.scan_way.SelectedIndexChanged += new System.EventHandler(this.scan_way_SelectedIndexChanged);
            // 
            // scanway
            // 
            this.scanway.AutoSize = true;
            this.scanway.Location = new System.Drawing.Point(10, 40);
            this.scanway.Name = "scanway";
            this.scanway.Size = new System.Drawing.Size(65, 12);
            this.scanway.TabIndex = 17;
            this.scanway.Text = "扫描方式：";
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(4, 283);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(63, 23);
            this.run_button.TabIndex = 16;
            this.run_button.Text = "运行";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // close_motor
            // 
            this.close_motor.Location = new System.Drawing.Point(112, 283);
            this.close_motor.Name = "close_motor";
            this.close_motor.Size = new System.Drawing.Size(58, 23);
            this.close_motor.TabIndex = 15;
            this.close_motor.Text = "返回";
            this.close_motor.UseVisualStyleBackColor = true;
            this.close_motor.Click += new System.EventHandler(this.close_motor_Click);
            // 
            // scanmodel_txt
            // 
            this.scanmodel_txt.FormattingEnabled = true;
            this.scanmodel_txt.Items.AddRange(new object[] {
            "8/min",
            "4/min",
            "2/min",
            "1/min",
            "0.5/min",
            "0.25/min",
            "0.125/min"});
            this.scanmodel_txt.Location = new System.Drawing.Point(84, 67);
            this.scanmodel_txt.Name = "scanmodel_txt";
            this.scanmodel_txt.Size = new System.Drawing.Size(90, 20);
            this.scanmodel_txt.TabIndex = 13;
            this.scanmodel_txt.Text = "8/min";
            this.scanmodel_txt.SelectedIndexChanged += new System.EventHandler(this.scanmodel_txt_SelectedIndexChanged_1);
            // 
            // scan_speed
            // 
            this.scan_speed.AutoSize = true;
            this.scan_speed.Location = new System.Drawing.Point(10, 67);
            this.scan_speed.Name = "scan_speed";
            this.scan_speed.Size = new System.Drawing.Size(65, 12);
            this.scan_speed.TabIndex = 12;
            this.scan_speed.Text = "扫描速度：";
            // 
            // run_model
            // 
            this.run_model.AutoSize = true;
            this.run_model.Location = new System.Drawing.Point(8, 98);
            this.run_model.Name = "run_model";
            this.run_model.Size = new System.Drawing.Size(65, 12);
            this.run_model.TabIndex = 11;
            this.run_model.Text = "轴动模式：";
            // 
            // stopangle_txt
            // 
            this.stopangle_txt.Location = new System.Drawing.Point(82, 190);
            this.stopangle_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopangle_txt.Multiline = true;
            this.stopangle_txt.Name = "stopangle_txt";
            this.stopangle_txt.Size = new System.Drawing.Size(90, 21);
            this.stopangle_txt.TabIndex = 10;
            this.stopangle_txt.Text = "10";
            this.stopangle_txt.Leave += new System.EventHandler(this.stopangle_txt_Leave_1);
            // 
            // stop_angle
            // 
            this.stop_angle.AutoSize = true;
            this.stop_angle.Location = new System.Drawing.Point(8, 195);
            this.stop_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stop_angle.Name = "stop_angle";
            this.stop_angle.Size = new System.Drawing.Size(65, 12);
            this.stop_angle.TabIndex = 4;
            this.stop_angle.Text = "停止角度：";
            // 
            // runmodel_txt
            // 
            this.runmodel_txt.FormattingEnabled = true;
            this.runmodel_txt.Items.AddRange(new object[] {
            "θ-2θ",
            "接收器单动",
            "X射线单动"});
            this.runmodel_txt.Location = new System.Drawing.Point(83, 98);
            this.runmodel_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runmodel_txt.Name = "runmodel_txt";
            this.runmodel_txt.Size = new System.Drawing.Size(90, 20);
            this.runmodel_txt.TabIndex = 1;
            this.runmodel_txt.Text = "θ-2θ";
            this.runmodel_txt.SelectedIndexChanged += new System.EventHandler(this.runmodel_txt_SelectedIndexChanged);
            // 
            // Full_scale
            // 
            this.Full_scale.Location = new System.Drawing.Point(108, 277);
            this.Full_scale.Name = "Full_scale";
            this.Full_scale.Size = new System.Drawing.Size(117, 21);
            this.Full_scale.TabIndex = 26;
            this.Full_scale.Text = "1000";
            // 
            // Sample_control
            // 
            this.Sample_control.Controls.Add(this.Amt);
            this.Sample_control.Controls.Add(this.Current_value);
            this.Sample_control.Controls.Add(this.Lb_Close);
            this.Sample_control.Controls.Add(this.label1);
            this.Sample_control.Controls.Add(this.LB_Open);
            this.Sample_control.Controls.Add(this.label15);
            this.Sample_control.Controls.Add(this.Down);
            this.Sample_control.Controls.Add(this.Up);
            this.Sample_control.Controls.Add(this.label4);
            this.Sample_control.Controls.Add(this.Adjust_hight);
            this.Sample_control.Controls.Add(this.Stop);
            this.Sample_control.Controls.Add(this.Reset);
            this.Sample_control.Controls.Add(this.label3);
            this.Sample_control.Location = new System.Drawing.Point(13, 115);
            this.Sample_control.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sample_control.Name = "Sample_control";
            this.Sample_control.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sample_control.Size = new System.Drawing.Size(204, 170);
            this.Sample_control.TabIndex = 28;
            this.Sample_control.TabStop = false;
            this.Sample_control.Text = "样品台控制";
            // 
            // Amt
            // 
            this.Amt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Amt.Location = new System.Drawing.Point(71, 103);
            this.Amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amt.Name = "Amt";
            this.Amt.Size = new System.Drawing.Size(72, 20);
            this.Amt.TabIndex = 19;
            this.Amt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Current_value
            // 
            this.Current_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Current_value.Location = new System.Drawing.Point(71, 43);
            this.Current_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Current_value.Name = "Current_value";
            this.Current_value.Size = new System.Drawing.Size(70, 20);
            this.Current_value.TabIndex = 18;
            this.Current_value.Text = "0";
            this.Current_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Close
            // 
            this.Lb_Close.Location = new System.Drawing.Point(151, 130);
            this.Lb_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lb_Close.Name = "Lb_Close";
            this.Lb_Close.Size = new System.Drawing.Size(49, 29);
            this.Lb_Close.TabIndex = 17;
            this.Lb_Close.Text = "率表关";
            this.Lb_Close.UseVisualStyleBackColor = true;
            this.Lb_Close.Click += new System.EventHandler(this.Lb_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "样品台最高调整为10mm";
            // 
            // LB_Open
            // 
            this.LB_Open.Location = new System.Drawing.Point(151, 16);
            this.LB_Open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB_Open.Name = "LB_Open";
            this.LB_Open.Size = new System.Drawing.Size(49, 29);
            this.LB_Open.TabIndex = 7;
            this.LB_Open.Text = "率表开";
            this.LB_Open.UseVisualStyleBackColor = true;
            this.LB_Open.Click += new System.EventHandler(this.LB_Open_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 103);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "强度值：";
            // 
            // Down
            // 
            this.Down.Enabled = false;
            this.Down.Location = new System.Drawing.Point(151, 94);
            this.Down.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(49, 29);
            this.Down.TabIndex = 8;
            this.Down.Text = "下降";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Enabled = false;
            this.Up.Location = new System.Drawing.Point(151, 56);
            this.Up.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(49, 29);
            this.Up.TabIndex = 7;
            this.Up.Text = "上升";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "调整高度：";
            // 
            // Adjust_hight
            // 
            this.Adjust_hight.Location = new System.Drawing.Point(71, 73);
            this.Adjust_hight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Adjust_hight.Name = "Adjust_hight";
            this.Adjust_hight.Size = new System.Drawing.Size(72, 21);
            this.Adjust_hight.TabIndex = 5;
            this.Adjust_hight.Text = "10.000";
            this.Adjust_hight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adjust_hight.SelectedItemChanged += new System.EventHandler(this.Adjust_hight_SelectedItemChanged);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(95, 136);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(43, 23);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(10, 136);
            this.Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(43, 23);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "复位";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "当前位置：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Go);
            this.groupBox1.Controls.Add(this.Shaft_model);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Step_width);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(204, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测角仪微调";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(151, 76);
            this.Go.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(49, 22);
            this.Go.TabIndex = 6;
            this.Go.Text = "前进";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Shaft_model
            // 
            this.Shaft_model.FormattingEnabled = true;
            this.Shaft_model.Items.AddRange(new object[] {
            "两臂联动",
            "射线管臂单动",
            "探测器臂单动"});
            this.Shaft_model.Location = new System.Drawing.Point(53, 82);
            this.Shaft_model.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Shaft_model.Name = "Shaft_model";
            this.Shaft_model.Size = new System.Drawing.Size(90, 20);
            this.Shaft_model.TabIndex = 4;
            this.Shaft_model.Text = "θ-2θ";
            this.Shaft_model.SelectedIndexChanged += new System.EventHandler(this.Shaft_model_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(151, 23);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 22);
            this.Back.TabIndex = 5;
            this.Back.Text = "后退";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Step_width
            // 
            this.Step_width.Location = new System.Drawing.Point(53, 49);
            this.Step_width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Step_width.Name = "Step_width";
            this.Step_width.Size = new System.Drawing.Size(88, 21);
            this.Step_width.TabIndex = 3;
            this.Step_width.Text = "2.00";
            this.Step_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "轴方式:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "步宽：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "测角仪步宽为0.01到2.00";
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived_1);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(487, 19);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(812, 747);
            this.zedGraphControl1.TabIndex = 29;
            // 
            // Xray_position
            // 
            this.Xray_position.AutoEllipsis = true;
            this.Xray_position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Xray_position.Location = new System.Drawing.Point(128, 64);
            this.Xray_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Xray_position.Name = "Xray_position";
            this.Xray_position.Size = new System.Drawing.Size(61, 18);
            this.Xray_position.TabIndex = 15;
            this.Xray_position.Text = "0";
            this.Xray_position.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // collect_position
            // 
            this.collect_position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collect_position.Location = new System.Drawing.Point(128, 96);
            this.collect_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.collect_position.Name = "collect_position";
            this.collect_position.Size = new System.Drawing.Size(61, 18);
            this.collect_position.TabIndex = 16;
            this.collect_position.Text = "0";
            this.collect_position.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "X射线当前位置θs：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "接收器当前位置θd：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.off);
            this.groupBox3.Controls.Add(this.turnon);
            this.groupBox3.Controls.Add(this.stop_text);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.turn_model);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 398);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(204, 83);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "测角仪角度调整";
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(151, 54);
            this.off.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(43, 22);
            this.off.TabIndex = 14;
            this.off.Text = "停止";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // turnon
            // 
            this.turnon.Location = new System.Drawing.Point(151, 18);
            this.turnon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.turnon.Name = "turnon";
            this.turnon.Size = new System.Drawing.Size(43, 22);
            this.turnon.TabIndex = 13;
            this.turnon.Text = "运行";
            this.turnon.UseVisualStyleBackColor = true;
            this.turnon.Click += new System.EventHandler(this.turnon_Click);
            // 
            // stop_text
            // 
            this.stop_text.Location = new System.Drawing.Point(50, 21);
            this.stop_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop_text.Multiline = true;
            this.stop_text.Name = "stop_text";
            this.stop_text.Size = new System.Drawing.Size(90, 21);
            this.stop_text.TabIndex = 12;
            this.stop_text.Text = "10";
            this.stop_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stop_text.Leave += new System.EventHandler(this.stop_text_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "停止角：";
            // 
            // turn_model
            // 
            this.turn_model.FormattingEnabled = true;
            this.turn_model.Items.AddRange(new object[] {
            "两臂联动",
            "射线管臂单动",
            "探测器臂单动"});
            this.turn_model.Location = new System.Drawing.Point(50, 58);
            this.turn_model.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.turn_model.Name = "turn_model";
            this.turn_model.Size = new System.Drawing.Size(90, 20);
            this.turn_model.TabIndex = 6;
            this.turn_model.Text = "两臂联动";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "轴方式:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 596);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.collect_position);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Xray_position);
            this.Controls.Add(this.Sample_control);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.parameter_set);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "通用串口测试程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.parameter_set.ResumeLayout(false);
            this.parameter_set.PerformLayout();
            this.Sample_control.ResumeLayout(false);
            this.Sample_control.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CLSTxtBoxAllReceive;
        private System.Windows.Forms.TextBox txtBoxAllReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.GroupBox parameter_set;
        private System.Windows.Forms.Label stop_angle;
        private System.Windows.Forms.ComboBox runmodel_txt;
        private System.Windows.Forms.Button savebotton;
        private System.Windows.Forms.Label run_model;
        private System.Windows.Forms.TextBox stopangle_txt;
        private System.Windows.Forms.ComboBox scanmodel_txt;
        private System.Windows.Forms.Label scan_speed;
        private System.Windows.Forms.Button close_motor;
        private System.Windows.Forms.Button adjust_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button xrf;
        private System.Windows.Forms.GroupBox Sample_control;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown Adjust_hight;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.ComboBox Shaft_model;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DomainUpDown Step_width;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LB_Open;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label State;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label Xray_position;
        private System.Windows.Forms.Label collect_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label scanstep;
        private System.Windows.Forms.ComboBox scan_way;
        private System.Windows.Forms.Label scanway;
        private System.Windows.Forms.DomainUpDown scan_step;
        private System.Windows.Forms.TextBox start_angle;
        private System.Windows.Forms.Label startangle;
        private System.Windows.Forms.DomainUpDown time_delay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox stop_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox turn_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button turnon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Full_scale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Zeroing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Lb_Close;
        private System.Windows.Forms.Label Current_value;
        private System.Windows.Forms.Label Amt;
        private System.Windows.Forms.TextBox Sample_name;
        private System.Windows.Forms.Label label13;


    }
}

