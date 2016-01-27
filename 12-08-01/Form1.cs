using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using ZedGraph;

namespace COMServer
{
    public partial class Form1 : Form
    {
        protected bool isInTimerFun = false;//是否正处在timer的事件中;
        string ReceiveData = "";//COM2接收到的数据,
        string ReceiveData1 = "";//COM5接收到的数据
        string [] contr_order=new string[15];//控制指令;
        string stepdelay = " 02 ";//步进延时
        int sd = 2;//步进延时
        int tdflag = 0;//计数定时
        string shaft_model = "00";//测角仪微调轴方式选择
        string rd = "";//COM2接收数据寄存器
        string rd1 = "";//COM5接收数据寄存器
        string runmodel = "";//转动方式选择
        int plantflag = 0;//画图标记
        int plantflag1 = 100;//画图标志
        static double zeroing = 0;//调零标志
        static double zeroingX = 0;//X射线调零标志
        static double zeroingD = 0;//接收器调零标志
        //double x1 = 0;//画点起始角度
        //double y1 = 0;//画点起始角度
        LineItem mycurve;
        //int k = 470;//停止角度的和值
        Queue<string> colloctdata = new Queue<string>();//画图收集的数据存放队列寄存器
        PointPairList list = new PointPairList();//绘图坐标存储
        public delegate void _SafeAddtrTextCall(string text);
        public static bool delay(double delaytime)//延时程序
        {
            DateTime now = DateTime.Now;
            double s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
            } while (s < delaytime);
            return true;
        }
        private delegate void setpaint();//实例化一个画图委托
        public void threadpaint()//自定义方法用于调用于线程间
        {
            setpaint d = new setpaint(paint);//实例化一个画图委托
            this.Invoke(d);//在拥有此控件的基础窗体句柄的线程上执行指定委托
        }

        public Form1()
        {
            InitializeComponent();
        }

        #region 窗体事件
        private void Form1_Load(object sender, EventArgs e)
        {
                serialPort1.PortName = "COM2";
                serialPort2.PortName = "COM5";
                //作为服务程序运行，需要自行打开串口
                OpenSerialPort();
                contr_order[0] = "68 03 01 08 00 00 00 00 00 00 00 00 0C 16";
                contr_order[1]="68 03 02 08 00 00 00 00 00 00 00 00 0D 16";
                contr_order[2]="68 03 82 08 00 00 00 00 00 00 00 00 8D 16";
                contr_order[3]="68 03 07 08 02 02 03 E8 03 E8 00 00 EC 16";
                turn_model.SelectedItem = "两臂联动";
                WriteData(contr_order[0]);
                for (double i=10;i>0; )
                {                                      
                    i = Double.Parse(i.ToString("#.###"));
                    Adjust_hight.Items.Add(i);
                    i = i -0.005;                  
                }
                for (double j = 2; j > 0; )
                {
                    j = Double.Parse(j.ToString("#.##"));
                    Step_width.Items.Add(j);
                    j = j - 0.01;
                }
                for (double k = 100; k > 0; )
                {
                    k=double.Parse(k.ToString("#.##"));
                    scan_step.Items.Add(k);
                    k=k-0.01;
                }
                for (double m = 1000; m > 0; )
                {
                    m=double.Parse(m.ToString("#.#"));
                    time_delay.Items.Add(m);
                    m = m - 0.1;
                }
                Full_scale.Text = Full_scale.Text;
                stop_angle.Text = stop_angle.Text;
                start_angle.Text = start_angle.Text;
                this.zedGraphControl1.GraphPane.Title.Text = "XRD数据采集";
                this.zedGraphControl1.GraphPane.XAxis.Title.Text = "角度2θ";
                this.zedGraphControl1.GraphPane.YAxis.Title.Text="采集数值";
        }

        /// <summary>
        /// 窗体关闭释放资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (serialPort1 != null || serialPort2 != null)
            {
                if (serialPort1.IsOpen||serialPort2.IsOpen)
                {
                    serialPort1.Close();
                    serialPort2.Close();
                }
                serialPort1.Dispose();
                serialPort2.Dispose();
            }
        }

        #endregion

        #region 打开和关闭串口
        /// <summary>
        /// 打开串口
        /// </summary>
        protected void OpenSerialPort()
        {
                try
                {
                    serialPort1.Open();

                    serialPort2.Open();

                    serialPort1.BaudRate = 9600;

                    serialPort1.DataBits = 8;

                    serialPort1.StopBits = StopBits.One;

                    serialPort1.Parity = Parity.None ;

                    serialPort2.BaudRate = 9600;

                    serialPort2.DataBits = 8;

                    serialPort2.StopBits = StopBits.One;

                    serialPort2.Parity = Parity.None ;

                    State.Text = serialPort1.PortName + " " + serialPort2.PortName+"已打开！";

                }
                catch (Exception e2)
                {
                    State.Text = e2.Message;
                    serialPort1.Dispose();
                    serialPort2.Dispose();
                }
            
        }
        #endregion

        #region 画图程序
        private void paint()
        {
            string s = "";
            if (colloctdata.Count > 0)
            {
                s = colloctdata.Dequeue();
                Xray_position.Text = ((System.Convert.ToDouble(System.Convert.ToInt16(s.Substring(24, 5).Replace(" ", ""), 16))/200)-zeroingX).ToString("0.000");
                collect_position.Text = ((System.Convert.ToDouble(System.Convert.ToInt16(s.Substring(30, 5).Replace(" ", ""), 16)) / 200)-zeroingD).ToString("0.000");
                if (string.Equals(s.Substring(0, 11), "68 03 07 08"))
                {
                    timer1.Enabled = true;
                    double x = System.Convert.ToDouble(System.Convert.ToDouble(System.Convert.ToInt16(s.Substring(30-plantflag, 5).Replace(" ", ""), 16)) / plantflag1)-zeroing;
                    double y = Math.Log10(System.Convert.ToDouble(System.Convert.ToInt32(s.Substring(12, 11).Replace(" ", ""), 16))+10);
                    string showdata = '\n' + x.ToString("0.000").PadRight(7) +'\t'+ y.ToString("0.0000").PadLeft(6) + "\r";
                    safeAddtrText(showdata);//显示数据的委托
                    /*double[] m1 = {x1,x };
                    double[] m2 = {y1,y };
                    mycurve=zedGraphControl1.GraphPane.AddCurve("", m1, m2, Color.Red, SymbolType.None);*/
                    list.Add(x, y);
                   //mycurve = zedGraphControl1.GraphPane.AddCurve("", list, Color.Red, SymbolType.None);
                   //mycurve.Line.IsAntiAlias = true;//设置连接线的抗锯齿效果 
                    this.zedGraphControl1.GraphPane.AxisChange();
                    //this.zedGraphControl1.Invalidate(zedGraphControl1.ClientRectangle);
                    //this.zedGraphControl1.Refresh();//屏幕刷新
                    //x1 = x;
                    //y1 = y;
                    /*if (string.Equals(contr_order[3].Substring(18, 11), s.Substring(24, 11)))
                    {
                        timer1.Enabled = false;
                        WriteData("68 03 04 08 00 00 00 00 00 00 00 00 0F 16");
                        delay(0.5);
                        WriteData("68 03 04 08 00 00 00 00 00 00 00 00 0F 16");
                        delay(0.5);
                        WriteData("68 03 01 08 00 00 00 00 00 00 00 00 0C 16");
                        delay(0.5);
                    }*/
                }
                if (string.Equals(s.Substring(0, 11), "68 03 0A 08"))
                {
                    Amt.Text = System.Convert.ToInt32(s.Substring(12, 11).Replace(" ",""),16).ToString();
                }
            }            
        }
        #endregion

        #region 定时刷新，定时画线
        private void timer1_Tick(object sender, EventArgs e)//定时刷新，定时画线
        {
            mycurve = zedGraphControl1.GraphPane.AddCurve("", list, Color.Red, SymbolType.None);
            mycurve.Line.IsAntiAlias = true;//设置连接线的抗锯齿效果 
            this.zedGraphControl1.GraphPane.AxisChange();
            this.zedGraphControl1.Refresh();
            timer1.Enabled = false;
        }
        #endregion

        #region 处理接收到的数据的委托

        //委托的实现
        private void safeAddtrText(string text)
        {

            if (this.InvokeRequired)
            {
                _SafeAddtrTextCall callALL =
                   delegate(string s)
                   {
                       //if (txtBoxAllReceive.Text.Length > 2048)
                       //    txtBoxAllReceive.Text = "";
                       //txtBoxAllReceive.Text += s + "  ";
                       txtBoxAllReceive.AppendText(s + ' ');
                   };
                this.Invoke(callALL, text);
            }
            else
            {
                txtBoxAllReceive.AppendText(text);
            }

        }
        #endregion

        #region 串口2接收数据事件响应
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int[] receivebuf = new int[14];
            int i=0;
            while (i<14)
            {               
                    receivebuf [i] = serialPort1.ReadByte();
                    ReceiveData += receivebuf[i].ToString("X").PadLeft(2, '0');
                    if(i<13)
                      ReceiveData += ' ';
                    ReceiveData = ReceiveData.ToUpper();
                    i++;
            }
            colloctdata.Enqueue(ReceiveData);
            Thread t = new Thread(new ThreadStart(threadpaint));
            t.Start();
            rd = ReceiveData;
            //safeAddtrText(ReceiveData);//显示数据的委托
            ReceiveData = "";
        }
        #endregion

        #region 串口5接收数据事件响应
        private void serialPort2_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            int[] receivebuf = new int[14];
            int i = 0;
            while (i < 14)
            {
                receivebuf[i] = serialPort2.ReadByte();
                ReceiveData1 += receivebuf[i].ToString("X").PadLeft(2, '0');
                if (i < 13)
                    ReceiveData1 += ' ';
                ReceiveData1 = ReceiveData1.ToUpper();
                i++;
            }
            rd1 = ReceiveData1;
            //safeAddtrText(ReceiveData1);//显示数据的委托
            ReceiveData1 = "";

        }

        #endregion

        #region 杂项
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CLSTxtBoxAllReceive_Click(object sender, EventArgs e)
        {
            txtBoxAllReceive.Text = "";
        }

        #endregion

        #region 向串口2发送数据
        /// <summary>
        /// 向串口发送数据
        /// </summary>       
        /// <param name="cmd">则为命令码</param>
        /// <returns>为空则执行正常，否则为异常信息</returns>
        protected string WriteData(string cmd)
        {
            string sResult = "";
            if (!serialPort1.IsOpen)
            {

                sResult = "串口未打开，串口号为：" + serialPort1.PortName;
                return sResult;
            }
            try
            {
                string sendvalue = "";
                sendvalue = cmd;
                byte[] StrBuffer = new byte[14];
                string[] hexstring=sendvalue.Split(' ');
                int k = 0;
                    for (int i = 0; i < 14;i++ )
                    {
                        try
                        {
                        k = int.Parse(hexstring[i], System.Globalization.NumberStyles.HexNumber);
                        StrBuffer[i] = (byte)k;
                        }
                        catch (Exception ex)
                        {
                            sResult += "使用hex发送数据出错，请检查发送的数据是否是16进制格式！详细信息：" + ex.Message;
                            return sResult;
                        }
                    }
                    serialPort1.Write(StrBuffer, 0, 14);
            }
            catch (Exception ex)
            {
                sResult = ex.Message;
            }
            return sResult;
        }
        #endregion

        #region 向串口5发送数据
        /// <summary>
        /// 向串口发送数据
        /// </summary>       
        /// <param name="cmd">则为命令码</param>
        /// <returns>为空则执行正常，否则为异常信息</returns>
        protected string WriteData1(string cmd)
        {
            string sResult = "";
            if (!serialPort2.IsOpen)
            {

                sResult = "串口未打开，串口号为：" + serialPort2.PortName;
                return sResult;
            }
            try
            {
                string sendvalue = "";
                sendvalue = cmd;
                byte[] StrBuffer = new byte[14];
                string[] hexstring = sendvalue.Split(' ');
                int k = 0;
                for (int i = 0; i < 14; i++)
                {
                    try
                    {
                        k = int.Parse(hexstring[i], System.Globalization.NumberStyles.HexNumber);
                        StrBuffer[i] = (byte)k;
                    }
                    catch (Exception ex)
                    {
                        sResult += "使用hex发送数据出错，请检查发送的数据是否是16进制格式！详细信息：" + ex.Message;
                        return sResult;
                    }
                }
                serialPort2.Write(StrBuffer, 0, 14);
            }
            catch (Exception ex)
            {
                sResult = ex.Message;
            }
            return sResult;
        }
        #endregion

        #region 右键菜单
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abForm = new AboutBox1();
            abForm.ShowDialog();
        }
        #endregion

        #region XRD扫描参数设定

        private void Zeroing_Leave(object sender, EventArgs e)
        {
            Zeroing.Text = Zeroing.Text;
        }

        private void scan_way_SelectedIndexChanged(object sender, EventArgs e)//扫描方式事件
        {
            if (scan_way.SelectedIndex > -1)
            {
                switch (scan_way.SelectedIndex)
                {
                    case 0:
                        scan_speed.Text = "扫描速度：";
                        scanmodel_txt.SelectedIndex = 0;
                        stepdelay = " 02 ";
                        sd = 2;
                        tdflag = 0;
                        scanmodel_txt.Visible = true;
                        scanmodel_txt.Enabled = true;
                        time_delay.Visible = false;
                        time_delay.Enabled = false;
                        break;
                    case 1:
                        scan_speed.Text = "计数定时";
                        stepdelay = " 00 ";
                        sd = 0;
                        tdflag = 1;
                        time_delay.Visible = true;
                        time_delay.Enabled = true;
                        scanmodel_txt.Visible = false;
                        scanmodel_txt.Enabled = false;
                        break;
                }
            }
        }

        private void runmodel_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (runmodel_txt.SelectedIndex > -1)
            {
                switch (runmodel_txt.SelectedIndex)
                {
                    case 0:
                        runmodel = "2θ";
                        plantflag = 0;
                        plantflag1 = 100;
                        break;
                    case 1:
                        plantflag =  0;
                        runmodel = "θd";
                        plantflag1 = 200;
                        break;
                    case 2:
                        plantflag =6;
                        runmodel = "θs";
                        plantflag1 = 200;
                        break;
                }
            }
            this.zedGraphControl1.GraphPane.XAxis.Title.Text = "角度" + runmodel;

        }


        private void scanmodel_txt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (scanmodel_txt.SelectedIndex > -1)
            {
                switch (scanmodel_txt.SelectedItem.ToString())
                {
                    case "8/min":
                        stepdelay = " 02 ";
                        sd = 2;
                        break;
                    case "4/min":
                        stepdelay = " 04 ";
                        sd = 4;
                        break;
                    case "2/min":
                        stepdelay = " 08 ";
                        sd = 8;
                        break;
                    case "1/min":
                        stepdelay = " 10 ";
                        sd = 16;
                        break;
                    case "0.5/min":
                        stepdelay = " 20 ";
                        sd = 32;
                        break;
                    case "0.25/min":
                        stepdelay = " 40 ";
                        sd = 64;
                        break;
                    case "0.125/min":
                        stepdelay = " 80 ";
                        sd = 128;
                        break;
                }
            } 
        }

        private void start_angle_Leave(object sender, EventArgs e)
        {
            start_angle.Text = start_angle.Text;
        }

        private void time_delay_SelectedItemChanged(object sender, EventArgs e)
        {
            time_delay.Text = time_delay.Text;
        }

        private void scan_step_SelectedItemChanged(object sender, EventArgs e)
        {
            scan_step.Text=scan_step.Text;
        }

        private void stopangle_txt_Leave_1(object sender, EventArgs e)                
        {
            stopangle_txt.Text = stopangle_txt.Text;
        }

        private void run_button_Click(object sender, EventArgs e)//运行
        {
            run_button.Enabled = false;
            list.Clear();//zedgraph清空历史缓存
            this.zedGraphControl1.GraphPane.CurveList.Clear();//zedgraph清空界面
            this.zedGraphControl1.GraphPane.GraphObjList.Clear();//zedgraph清空界面
            this.zedGraphControl1.GraphPane.XAxis.Scale.Min = System.Convert.ToDouble(start_angle.Text);
            this.zedGraphControl1.GraphPane.XAxis.Scale.Max = System.Convert.ToDouble(stopangle_txt.Text);
            //this.zedGraphControl1.GraphPane.YAxis.Scale.Max = System.Convert.ToDouble(Full_scale.Text);
            this.zedGraphControl1.GraphPane.AxisChange();
            this.zedGraphControl1.Refresh();
            //寻找当前位置
            //string purposelocation1 = "00 00";
            //string purposelocation2 = "00 00";
            if (runmodel_txt.SelectedIndex > -1)//零点调整
            {
                switch (runmodel_txt.SelectedIndex)
                {
                    case 0:
                        zeroingD += System.Convert.ToDouble(Zeroing.Text);
                        zeroingX += System.Convert.ToDouble(Zeroing.Text);
                        zeroing = zeroingD*2;
                        break;
                    case 1:
                        zeroingD += System.Convert.ToDouble(Zeroing.Text);//探测器的调零
                        zeroing = zeroingD;
                        break;
                    case 2:
                        zeroingX += System.Convert.ToDouble(Zeroing.Text);//射线管的调零
                        zeroing = zeroingX;
                        break;
                }
            }
            WriteData(contr_order[0]);
            while (!string.Equals("68 03 81 08", rd.Substring(0, 11)))
                delay(0.005);
            WriteData("68 03 03 08 00 00 00 00 00 00 00 00 0E 16");
            while (!string.Equals("68 03 83 08", rd.Substring(0, 11)))
                delay(0.005);
            string purposelocation1 = rd.Substring(24, 5);
            int p1 = System.Convert.ToInt16(rd.Substring(24, 2).Replace(" ", ""), 16);
            int p2 = System.Convert.ToInt16(rd.Substring(27, 2).Replace(" ", ""), 16);
            string purposelocation2 = rd.Substring(30, 5);
            int p3 = System.Convert.ToInt16(rd.Substring(30, 2).Replace(" ", ""), 16);
            int p4 = System.Convert.ToInt16(rd.Substring(33, 2).Replace(" ", ""), 16);

            //开始值
            Int16 startanglePos1 = 0;
            Int16 startanglePos2 = 0;
            string ssta1 = "";
            string ssta2 = "";
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            startanglePos1 = System.Convert.ToInt16(plantflag1 * (Convert.ToDouble(start_angle.Text)) + zeroingX * 200);//射线管初始角位置
            ssta1 = startanglePos1.ToString("X").PadLeft(4, '0');
            s1 = ssta1.Substring(0, 2);
            s2 = ssta1.Substring(2, 2);
            startanglePos2 = System.Convert.ToInt16(plantflag1 * (Convert.ToDouble(start_angle.Text)) + zeroingD * 200);//探测器初始角位置
            ssta2 = startanglePos2.ToString("X").PadLeft(4, '0');
            s3 = ssta2.Substring(0, 2);
            s4 = ssta2.Substring(2, 2);
            int startangle1 = System.Convert.ToInt16(s1, 16);
            int startangle2 = System.Convert.ToInt16(s2, 16);
            int startangle3 = System.Convert.ToInt16(s3, 16);
            int startangle4 = System.Convert.ToInt16(s4, 16);
            int k = 0;
            int i = 0;
            int j = 0;
            if (runmodel_txt.SelectedIndex > -1)
            {
                switch (runmodel_txt.SelectedItem.ToString())
                {
                    case "θ-2θ":
                        purposelocation1 = s1 + " " + s2;
                        purposelocation2 = s3 + " " + s4;
                        k = startangle1 + startangle2 + startangle3 + startangle4;
                        break;
                    case "接收器单动":
                        purposelocation2 = s3 + " " + s4;
                        k = startangle3 + startangle4 + p1 + p2;
                        break;
                    case "X射线单动":
                        purposelocation1 = s1 + " " + s2;
                        k = startangle1 + startangle2+p3+p4;
                        break;
                }
            }
            i = (k + 13) % 256;
            j = (k + 141) % 256;
            contr_order[1] = "68 03 02 08 00 " + purposelocation1 + " " + purposelocation2 + " 00 00 00 " + i.ToString("X").PadLeft(2, '0') + " 16";
            contr_order[2] = "68 03 82 08" + " 00 00 00 00 " + purposelocation1 + " " + purposelocation2 + " " + j.ToString("X").PadLeft(2, '0') + " 16";
            //MessageBox.Show(contr_order[1]);

            //叠扫指令
            Int16 stopanglePos1 = 0;//X射线停止角位置
            Int16 stopanglePos2 = 0;//探测器停止角位置
            Int16 se = 0;
            string soe1 = "";
            string soe2 = "";
            string so1 = "";
            string so2 = "";
            string so3 = "";
            string so4 = "";
            string sso = "";
            string stoppurposelocation1 = "03 E8";//停止角度初始位置
            string stoppurposelocation2 = "03 E8";//停止角度初始位置
            stopanglePos1 = System.Convert.ToInt16(plantflag1 * (Convert.ToDouble(stopangle_txt.Text))+zeroingX*200);//停止角度X射线调整
            soe1 = stopanglePos1.ToString("X").PadLeft(4, '0');
            so1 = soe1.Substring(0, 2);
            so2 = soe1.Substring(2, 2);
            int stopangle1 = System.Convert.ToInt16(so1, 16);
            int stopangle2 = System.Convert.ToInt16(so2, 16);
            stopanglePos2 = System.Convert.ToInt16(plantflag1 * (Convert.ToDouble(stopangle_txt.Text)) + zeroingD * 200);//停止角度探测器调整
            soe2 = stopanglePos2.ToString("X").PadLeft(4, '0');
            so3 = soe2.Substring(0, 2);
            so4 = soe2.Substring(2, 2);
            int stopangle3 = System.Convert.ToInt16(so3, 16);
            int stopangle4 = System.Convert.ToInt16(so4, 16);
            int id = 0;
            int kd = 0;
            int tdf = 0;//步进扫描时延时时间
            string tdf1 = "";
            string tdf2 = "";
            if (runmodel_txt.SelectedIndex > -1)
            {
                switch (runmodel_txt.SelectedItem.ToString())
                {
                    case "θ-2θ":
                        stoppurposelocation1 = so1 + " " + so2;
                        stoppurposelocation2 = so3 + " " + so4;
                        kd = stopangle1 + stopangle2 + stopangle3 + stopangle4;
                        se = System.Convert.ToInt16((System.Convert.ToDouble(scan_step.Text)) * 100);
                        break;
                    case "接收器单动":
                        stoppurposelocation1 = purposelocation1;
                        stoppurposelocation2 = so3 + " " + so4;
                        kd = stopangle3 + stopangle4 + p1 + p2;
                        se = System.Convert.ToInt16((System.Convert.ToDouble(scan_step.Text)) * 100);
                        break;
                    case "X射线单动":
                        stoppurposelocation1 = so1 + " " + so2;
                        stoppurposelocation2 = purposelocation2;
                        kd = stopangle1 + stopangle2 + p3 + p4;
                        se = System.Convert.ToInt16((System.Convert.ToDouble(scan_step.Text)) * 100);
                        break;
                }
            }
            tdf = tdflag * System.Convert.ToInt16((System.Convert.ToDouble(time_delay.Text)) * 10);
            //MessageBox.Show(tdf.ToString());
            sso = se.ToString("X").PadLeft(2, '0');
            tdf1 = (tdf / 256).ToString("X").PadLeft(2, '0');
            tdf2 = (tdf %256).ToString("X").PadLeft(2, '0');
            id = (kd + sd + 18 + (tdf / 256) + (tdf % 256) + se) % 256;
            contr_order[3] = "68 03 07 08" + stepdelay + sso + " " + stoppurposelocation1 + " " + stoppurposelocation2 + " "+tdf1+" " +tdf2 +" " + id.ToString("X").PadLeft(2, '0') + " 16";//叠扫
            //MessageBox.Show(contr_order[3])
            //MessageBox.Show(stopanglePos1.ToString());
            //MessageBox.Show(stopanglePos2.ToString());
            //叠扫设置
            WriteData(contr_order[1]);
            while (!string.Equals(contr_order[2], rd))
                delay(0.005);
            WriteData("68 03 04 08 01 00 00 00 00 00 00 00 10 16");
            WriteData(contr_order[3]);
            while (!string.Equals(contr_order[3].Substring(18,11), rd.Substring(24,11)))
                delay(0.005);
            /*WriteData("68 03 04 08 00 00 00 00 00 00 00 00 0F 16");
            while (!string.Equals("68 03 84 08", rd.Substring(0, 11)))
                delay(0.005);*/
           /* delay(0.05);
            WriteData("68 03 04 08 00 00 00 00 00 00 00 00 0F 16");
            delay(0.05);*/
            WriteData("68 03 01 08 00 00 00 00 00 00 00 00 0C 16");
            /*while (!string.Equals("68 03 81 08", rd.Substring(0, 11)))
                delay(0.005);*/
            //delay(0.1);
            //timer1.Enabled = false;
            //MessageBox.Show("数据采集完！");
            /*WriteData(contr_order[1]);//回到初始位置
            while (!string.Equals(contr_order[2], rd))
                delay(0.005);*/

        }

        private void close_motor_Click(object sender, EventArgs e)//关电机
        {
            //x1 = 0;
            //y1 = 0;
            timer1.Enabled = false;
            Zeroing.Text = "0";
            WriteData(contr_order[0]);
            /*while (!string.Equals("68 03 81 08", rd.Substring(0, 11)))
                delay(0.005);*/
           /* WriteData("68 03 04 08 00 00 00 00 00 00 00 00 0F 16");
            while (!string.Equals("68 03 84 08", rd.Substring(0, 11)))
                delay(0.005);*/
            //WriteData(contr_order[0]);
            if (MessageBox.Show("是否保存数据？", "数据保存", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string filename = Sample_name.Text;//文件以日期的方式存储
                using (StreamWriter sw = new StreamWriter(@"D:\xrd\" + filename + ".txt"))
                {
                    sw.Write(txtBoxAllReceive.Text);
                }
            }
            else
            {
                txtBoxAllReceive.Text = "";
            } 
          run_button.Enabled = true;
        }

        #endregion

        #region 校准
        private void adjust_button_Click(object sender, EventArgs e)
        {
            
            WriteData("68 03 00 08 00 08 00 05 00 00 00 00 18 16");
            run_button.Enabled = false;
            while (!string.Equals(rd, "68 03 80 08 00 00 00 00 03 E8 03 E8 61 16"))
                delay (0.005);
            rd = "";
            run_button.Enabled = true;
        }
        #endregion

        #region  保存返回的数据
        private void savebotton_Click(object sender, EventArgs e)
        {
            string filename = DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss");//文件以日期的方式存储
            using (StreamWriter sw = new StreamWriter(@"D:\xrd\"+filename+".txt"))
            {
                sw.Write(txtBoxAllReceive.Text);
            }

        }
        #endregion

        #region xrf采集数据
        private void xrf_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(@"F:\浙江电子科技大学软件最后版本20100422\AMTEK公司能谱获取软件\ADMCA\ADMCA.exe");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        #endregion

        #region  样品台控制
        private void LB_Open_Click(object sender, EventArgs e)//打开率表
        {
            WriteData("68 03 0A 08 00 00 00 00 00 00 00 00 15 16");
        }

        private void Lb_Close_Click(object sender, EventArgs e)//关闭率表
        {
            WriteData(contr_order[0]);
        }

        private void Reset_Click(object sender, EventArgs e)//复位
        {
            WriteData1("68 03 30 08 00 00 00 00 00 00 00 00 3B 16");
            while (!string.Equals("68 03 B0 08 00 00 00 00 00 00 00 00 BB 16", rd1))
                delay(0.005);
            rd1 = "";
            MessageBox.Show("复位成功!");
            Current_value.Text = "0";
            Stop.Enabled = true;
            Up.Enabled = true;
            Down.Enabled = true;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            int i=0, j=0,adjust=0;
            string s="";
            string s1="";
            string s2="";
            if ((System.Convert.ToDouble(Current_value.Text) + System.Convert.ToDouble(Adjust_hight.Text)) <= 10)//调整高度小于10
            {
                adjust = System.Convert.ToInt16((System.Convert.ToDouble(Current_value.Text) + System.Convert.ToDouble(Adjust_hight.Text)) * 800);
                s = adjust.ToString("X").PadLeft(4, '0');
                s1 = s.Substring(0, 2);
                s2 = s.Substring(2, 2);
                i = (adjust/256)+(adjust%256) + 61;
                j = (adjust / 256) + (adjust % 256) + 189;
                contr_order[4] = "68 03 32 08 00 00 00 "+s1+" " + s2 + " 00 00 00 " + (i % 256).ToString("X").PadLeft(2, '0') + " 16";
                WriteData1(contr_order[4]);
                while (!string.Equals("68 03 B2 08 00 00 00 00 00 00 " + s1 + " " + s2 + " " + (j % 256).ToString("X").PadLeft(2, '0') + " 16", rd1))
                    delay(0.005);
                MessageBox.Show("到达设定位置!");
                Current_value.Text = (System.Convert.ToDouble(Current_value.Text) + System.Convert.ToDouble(Adjust_hight.Text)).ToString();
            }
            else
            {
                MessageBox.Show("超出最大高度10!");
            }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, adjust = 0;
            string s = "";
            string s1 = "";
            string s2 = "";
            if ((System.Convert.ToDouble(Current_value.Text) - System.Convert.ToDouble(Adjust_hight.Text)) >=0)//调整高度大于0
            {
                adjust = System.Convert.ToInt16((System.Convert.ToDouble(Current_value.Text) - System.Convert.ToDouble(Adjust_hight.Text)) * 800);
                s = adjust.ToString("X").PadLeft(4, '0');
                s1 = s.Substring(0, 2);
                s2 = s.Substring(2, 2);
                i = (adjust / 256) + (adjust % 256) + 61;
                j = (adjust / 256) + (adjust % 256) + 189;
                contr_order[5] = "68 03 32 08 00 00 00 " + s1 + " " + s2 + " 00 00 00 " + (i % 256).ToString("X").PadLeft(2, '0') + " 16";
                WriteData1(contr_order[5]);
                while (!string.Equals("68 03 B2 08 00 00 00 00 00 00 " + s1 + " " + s2 + " " + (j % 256).ToString("X").PadLeft(2, '0') + " 16", rd1))
                    delay(0.005);
                MessageBox.Show("到达设定位置!");
                Current_value.Text = (System.Convert.ToDouble(Current_value.Text) - System.Convert.ToDouble(Adjust_hight.Text)).ToString();
            }
            else
            {
                MessageBox.Show("调整高度不为负值!");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            WriteData1("68 03 31 08 00 00 00 00 00 00 00 00 3C 16");
        }
        
        private void Adjust_hight_SelectedItemChanged(object sender, EventArgs e)
        {
            Adjust_hight.Text = Adjust_hight.Text;
        }

        #endregion

        #region 测角仪微调
        private void Shaft_model_SelectedIndexChanged(object sender, EventArgs e)//轴方式选择
        {
            if (Shaft_model.SelectedIndex > -1)
            {
                switch (Shaft_model.SelectedIndex)
                {
                    case 0:
                        shaft_model = "00";
                        break;
                    case 1:
                        shaft_model = "01";
                        break;
                    case 2:
                        shaft_model = "02";
                        break;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)//后退按钮
        {
            int value = System.Convert.ToInt16(System.Convert.ToDouble(Step_width.Text) * 100);
            string s = value.ToString("X").PadLeft(4, '0').Substring(2, 2);
            int i = System.Convert.ToInt16(shaft_model);
            int j = (22 + value + i) % 256;
            WriteData("68 03 0B 08 " + s + " 00 " + shaft_model + " 00 00 00 00 00 " + j.ToString("X").PadLeft(2, '0') + " 16");
        }

        private void Go_Click(object sender, EventArgs e)//前进按钮
        {
            int value = System.Convert.ToInt16(System.Convert.ToDouble(Step_width.Text) * 100);
            string s = value.ToString("X").PadLeft(2, '0');
            int i = System.Convert.ToInt16(shaft_model);
            int j = (23 + value + i) % 256;
            WriteData("68 03 0B 08 " + s + " 01 " + shaft_model + " 00 00 00 00 00 " + j.ToString("X").PadLeft(2, '0') + " 16");

        }

        #endregion

        #region 测角仪角度调整
        private void stop_text_Leave(object sender, EventArgs e)
        {
            stop_text.Text = stop_text.Text;
            if (System.Convert.ToDouble(stop_text.Text) > 50)
            {
                MessageBox.Show("转动角度过大！");
            }
        }

        private void turnon_Click(object sender, EventArgs e)
        {
            stop_text.Text = stop_text.Text;
            if (System.Convert.ToDouble(stop_text.Text) > 50)
            {
                MessageBox.Show("转动角度过大！");
            }
            else
            {
                WriteData(contr_order[0]);
                delay(0.05);
                WriteData("68 03 03 08 00 00 00 00 00 00 00 00 0E 16");
                while (!string.Equals("68 03 83 08", rd.Substring(0, 11)))
                    delay(0.005);
                string purposelocation1 = rd.Substring(24, 5);
                int p1 = System.Convert.ToInt16(rd.Substring(24, 2).Replace(" ", ""), 16);
                int p2 = System.Convert.ToInt16(rd.Substring(27, 2).Replace(" ", ""), 16);
                string purposelocation2 = rd.Substring(30, 5);
                int p3 = System.Convert.ToInt16(rd.Substring(30, 2).Replace(" ", ""), 16);
                int p4 = System.Convert.ToInt16(rd.Substring(33, 2).Replace(" ", ""), 16);
                Int16 startangle=0;
                string s = "";
                string s1 = "";
                string s2 = "";
                startangle = System.Convert.ToInt16(200* Convert.ToDouble(stop_text.Text));
                s = startangle.ToString("X").PadLeft(4, '0');
                s1 = s.Substring(0, 2);
                s2 = s.Substring(2, 2);
                int startangle1 = System.Convert.ToInt16(s1, 16);
                int startangle2 = System.Convert.ToInt16(s2, 16);
                int k = 0;
                int i = 0;
                if (turn_model.SelectedIndex > -1)
                {
                    switch (turn_model.SelectedItem.ToString())
                    {
                        case "两臂联动":
                            purposelocation1 =s1 + " " + s2;
                            purposelocation2 = purposelocation1;
                            k = (startangle1 + startangle2) * 2;
                            break;
                        case "射线管臂单动":
                            purposelocation1 = s1 + " " + s2;
                            k = startangle1 + startangle2 + p3 + p4;
                            break;
                        case "探测器臂单动":
                            purposelocation2 = s1 + " " + s2;
                            k = startangle1 + startangle2 + p1 + p2;
                            break;
                    }
                }
                i = (k + 13) % 256;
                WriteData("68 03 02 08 00 " + purposelocation1 + " " + purposelocation2 + " 00 00 00 " + i.ToString("X").PadLeft(2, '0') + " 16");
            }
        }

        private void off_Click(object sender, EventArgs e)
        {
            WriteData(contr_order[0]);
        }

        #endregion

       


    }
}