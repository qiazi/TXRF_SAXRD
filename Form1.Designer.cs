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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxMSG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTrimSpace = new System.Windows.Forms.CheckBox();
            this.chBoxIsHex = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxSend = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.isHexShow = new System.Windows.Forms.CheckBox();
            this.CLSTxtBoxAllReceive = new System.Windows.Forms.Button();
            this.txtBoxAllReceive = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.btnOpenSerialPort = new System.Windows.Forms.Button();
            this.ComboBoxPortNum = new System.Windows.Forms.ComboBox();
            this.comboBoxBondRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBPortState = new System.Windows.Forms.Label();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.btnCloseSerialPort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDateBits = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxMSG);
            this.groupBox3.Location = new System.Drawing.Point(16, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1173, 161);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // txtBoxMSG
            // 
            this.txtBoxMSG.Location = new System.Drawing.Point(19, 25);
            this.txtBoxMSG.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMSG.Multiline = true;
            this.txtBoxMSG.Name = "txtBoxMSG";
            this.txtBoxMSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMSG.Size = new System.Drawing.Size(1145, 128);
            this.txtBoxMSG.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTrimSpace);
            this.groupBox1.Controls.Add(this.chBoxIsHex);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBoxSend);
            this.groupBox1.Location = new System.Drawing.Point(16, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1173, 178);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // checkBoxTrimSpace
            // 
            this.checkBoxTrimSpace.AutoSize = true;
            this.checkBoxTrimSpace.Location = new System.Drawing.Point(201, 150);
            this.checkBoxTrimSpace.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxTrimSpace.Name = "checkBoxTrimSpace";
            this.checkBoxTrimSpace.Size = new System.Drawing.Size(119, 19);
            this.checkBoxTrimSpace.TabIndex = 7;
            this.checkBoxTrimSpace.Text = "去掉所有空格";
            this.checkBoxTrimSpace.UseVisualStyleBackColor = true;
            // 
            // chBoxIsHex
            // 
            this.chBoxIsHex.AutoSize = true;
            this.chBoxIsHex.Location = new System.Drawing.Point(136, 148);
            this.chBoxIsHex.Margin = new System.Windows.Forms.Padding(4);
            this.chBoxIsHex.Name = "chBoxIsHex";
            this.chBoxIsHex.Size = new System.Drawing.Size(53, 19);
            this.chBoxIsHex.TabIndex = 6;
            this.chBoxIsHex.Text = "HEX";
            this.chBoxIsHex.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(8, 142);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 249);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "去掉所有空格";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(136, 246);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "HEX";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBoxSend
            // 
            this.txtBoxSend.Location = new System.Drawing.Point(8, 25);
            this.txtBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSend.Multiline = true;
            this.txtBoxSend.Name = "txtBoxSend";
            this.txtBoxSend.Size = new System.Drawing.Size(1156, 109);
            this.txtBoxSend.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.isHexShow);
            this.groupBox5.Controls.Add(this.CLSTxtBoxAllReceive);
            this.groupBox5.Controls.Add(this.txtBoxAllReceive);
            this.groupBox5.Location = new System.Drawing.Point(23, 439);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1165, 239);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receive";
            // 
            // isHexShow
            // 
            this.isHexShow.AutoSize = true;
            this.isHexShow.Location = new System.Drawing.Point(3, 168);
            this.isHexShow.Margin = new System.Windows.Forms.Padding(4);
            this.isHexShow.Name = "isHexShow";
            this.isHexShow.Size = new System.Drawing.Size(53, 19);
            this.isHexShow.TabIndex = 2;
            this.isHexShow.Text = "HEX";
            this.isHexShow.UseVisualStyleBackColor = true;
            // 
            // CLSTxtBoxAllReceive
            // 
            this.CLSTxtBoxAllReceive.Location = new System.Drawing.Point(11, 25);
            this.CLSTxtBoxAllReceive.Margin = new System.Windows.Forms.Padding(4);
            this.CLSTxtBoxAllReceive.Name = "CLSTxtBoxAllReceive";
            this.CLSTxtBoxAllReceive.Size = new System.Drawing.Size(39, 122);
            this.CLSTxtBoxAllReceive.TabIndex = 1;
            this.CLSTxtBoxAllReceive.Text = "C L S";
            this.CLSTxtBoxAllReceive.UseVisualStyleBackColor = true;
            this.CLSTxtBoxAllReceive.Click += new System.EventHandler(this.CLSTxtBoxAllReceive_Click);
            // 
            // txtBoxAllReceive
            // 
            this.txtBoxAllReceive.Location = new System.Drawing.Point(57, 25);
            this.txtBoxAllReceive.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAllReceive.Multiline = true;
            this.txtBoxAllReceive.Name = "txtBoxAllReceive";
            this.txtBoxAllReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxAllReceive.Size = new System.Drawing.Size(1099, 205);
            this.txtBoxAllReceive.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxParity);
            this.groupBox2.Controls.Add(this.btnOpenSerialPort);
            this.groupBox2.Controls.Add(this.ComboBoxPortNum);
            this.groupBox2.Controls.Add(this.comboBoxBondRate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LBPortState);
            this.groupBox2.Controls.Add(this.comboBoxStopBit);
            this.groupBox2.Controls.Add(this.btnCloseSerialPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxDateBits);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1184, 61);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(611, 22);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(77, 23);
            this.comboBoxParity.TabIndex = 11;
            this.comboBoxParity.Visible = false;
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(715, 21);
            this.btnOpenSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(68, 29);
            this.btnOpenSerialPort.TabIndex = 2;
            this.btnOpenSerialPort.Text = "打开";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // ComboBoxPortNum
            // 
            this.ComboBoxPortNum.FormattingEnabled = true;
            this.ComboBoxPortNum.Location = new System.Drawing.Point(80, 19);
            this.ComboBoxPortNum.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxPortNum.Name = "ComboBoxPortNum";
            this.ComboBoxPortNum.Size = new System.Drawing.Size(64, 23);
            this.ComboBoxPortNum.TabIndex = 3;
            // 
            // comboBoxBondRate
            // 
            this.comboBoxBondRate.FormattingEnabled = true;
            this.comboBoxBondRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBoxBondRate.Location = new System.Drawing.Point(343, 21);
            this.comboBoxBondRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBondRate.Name = "comboBoxBondRate";
            this.comboBoxBondRate.Size = new System.Drawing.Size(76, 23);
            this.comboBoxBondRate.TabIndex = 15;
            this.comboBoxBondRate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "串口号:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "波特率:";
            this.label6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "状态:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "停止位:";
            this.label5.Visible = false;
            // 
            // LBPortState
            // 
            this.LBPortState.AutoSize = true;
            this.LBPortState.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBPortState.Location = new System.Drawing.Point(929, 29);
            this.LBPortState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPortState.Name = "LBPortState";
            this.LBPortState.Size = new System.Drawing.Size(55, 15);
            this.LBPortState.TabIndex = 6;
            this.LBPortState.Text = "NotNow";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(499, 21);
            this.comboBoxStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(49, 23);
            this.comboBoxStopBit.TabIndex = 12;
            this.comboBoxStopBit.Visible = false;
            // 
            // btnCloseSerialPort
            // 
            this.btnCloseSerialPort.Enabled = false;
            this.btnCloseSerialPort.Location = new System.Drawing.Point(791, 21);
            this.btnCloseSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSerialPort.Name = "btnCloseSerialPort";
            this.btnCloseSerialPort.Size = new System.Drawing.Size(72, 29);
            this.btnCloseSerialPort.TabIndex = 7;
            this.btnCloseSerialPort.Text = "关闭";
            this.btnCloseSerialPort.UseVisualStyleBackColor = true;
            this.btnCloseSerialPort.Click += new System.EventHandler(this.btnCloseSerialPort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验:";
            this.label4.Visible = false;
            // 
            // comboBoxDateBits
            // 
            this.comboBoxDateBits.FormattingEnabled = true;
            this.comboBoxDateBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDateBits.Location = new System.Drawing.Point(213, 21);
            this.comboBoxDateBits.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDateBits.Name = "comboBoxDateBits";
            this.comboBoxDateBits.Size = new System.Drawing.Size(51, 23);
            this.comboBoxDateBits.TabIndex = 9;
            this.comboBoxDateBits.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 745);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "通用串口测试程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxMSG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxSend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CLSTxtBoxAllReceive;
        private System.Windows.Forms.TextBox txtBoxAllReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Button btnOpenSerialPort;
        private System.Windows.Forms.ComboBox ComboBoxPortNum;
        private System.Windows.Forms.ComboBox comboBoxBondRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBPortState;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.Button btnCloseSerialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDateBits;
        private System.Windows.Forms.CheckBox checkBoxTrimSpace;
        private System.Windows.Forms.CheckBox chBoxIsHex;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox isHexShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
       
    }
}

