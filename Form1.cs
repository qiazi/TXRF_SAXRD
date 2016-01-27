using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace COMServer
{
    public partial class Form1 : Form
    {
        protected bool isInTimerFun = false;//�Ƿ�������timer���¼���
        string ReceiveData = "";//���յ�������
        //�Ӵ����ж�ȡ���ݵ�ί��
        public delegate void _SafeAddtrTextCall(string text);
        /// <summary>
        /// ����Ϣ��ʾ��textbox�ϲ�������־��ί��
        /// </summary>
        /// <param name="msg">Ҫ��ʾ����Ϣ</param>
        private delegate void ShowMSgDelegate(string msg);//����Ϣ��ʾ��textbox�ϲ�������־��ί��
        /// <summary>
        /// ���쳣��Ϣ��ʾ��textbox�ϲ�������־��ί��
        /// </summary>
        /// <param name="msg">Ҫ��ʾ���쳣��Ϣ</param>
        private delegate void ShowExceptionMSgDelegate(Exception msg);//���쳣��Ϣ��ʾ��textbox�ϲ�������־��ί��
        /// <summary>
        /// ����Ԫ����֤Щ��־��ʱ����־�ļ������д������
        /// </summary>
        Mutex mu = new Mutex(false);//����Ԫ����֤Щ��־��ʱ����־�ļ������д������
        /// <summary>
        /// ����Ԫ����֤д�쳣��־��ʱ����־�ļ������д������
        /// </summary>
        Mutex muExceptionLog = new Mutex(false);//����Ԫ����֤д�쳣��־��ʱ����־�ļ������д������

        public Form1()
        {
            InitializeComponent();
        }

        #region �����¼�
        private void Form1_Load(object sender, EventArgs e)
        {
            //SetMSG("�������������");
            string portNum = "SerialPort Count:";

            try
            {
                //���ô��ڵ�Ĭ�ϲ���
                portNum += SerialPort.GetPortNames().Length.ToString();
                for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
                {
                    portNum += "\r\n" + SerialPort.GetPortNames().GetValue(i).ToString() + "\r\n";

                    ComboBoxPortNum.Items.Add(SerialPort.GetPortNames().GetValue(i).ToString());

                }
                SetMSG(portNum);
                ComboBoxPortNum.SelectedIndex = 0;
                comboBoxDateBits.SelectedIndex = 3;
                comboBoxParity.SelectedIndex = 2;
                comboBoxStopBit.SelectedIndex = 0;
                comboBoxBondRate.SelectedIndex = 3;
                //��Ϊ����������У���Ҫ���д򿪴���
                OpenSerialPort();
              
            }
            catch
            {               
                portNum += "0\r\nTheir is no any SerialPort on your computer!";
                SetMSG(portNum);
            }
        }

        /// <summary>
        /// ����ر��ͷ���Դ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1 != null)
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }
                    serialPort1.Dispose();
                }
            }
            catch (Exception ex)
            {
                SetMSG("�ر�ʱ��������" + ex.Message);
            }
        }

        #endregion

        #region �򿪺͹رմ���
        /// <summary>
        /// �򿪴���
        /// </summary>
        protected void OpenSerialPort()
        {
            if (ComboBoxPortNum.Text.ToString() != "")
            {
                serialPort1.PortName = ComboBoxPortNum.Text.ToString().Trim();
                try
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                    }

                    LBPortState.Text = serialPort1.PortName + "�Ѵ򿪣�";
                    
                        serialPort1.BaudRate =19200;
                    
                        serialPort1.DataBits = 8;
                                     
                        serialPort1.StopBits = StopBits.One;
                        
                        serialPort1.Parity = Parity.Even;
                    
                    btnSend.Enabled = true;
                    btnCloseSerialPort.Enabled = true;
                    btnOpenSerialPort.Enabled = false;
                   
                }
                catch (Exception e2)
                {
                    LBPortState.Text = e2.Message;
                    //toolStripStatusLabel1.Text = e2.Message;
                    serialPort1.Dispose();
                }
            }
            else
            {
                LBPortState.Text = "��ѡ�񴮿ڣ�";
            }
        }
        //�򿪴���
        private void btnOpenSerialPort_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }

        //�رմ���
        private void btnCloseSerialPort_Click(object sender, EventArgs e)
        {
           
            if (ComboBoxPortNum.Text.ToString() != "")
            {

                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();

                    }

                    LBPortState.Text = serialPort1.PortName + "�ѹرգ�";
                    btnSend.Enabled = false;
                    btnOpenSerialPort.Enabled = true;
                    btnCloseSerialPort.Enabled = false;
                   
                }
                catch (Exception e2)
                {
                    LBPortState.Text = e2.Message;
                    serialPort1.Dispose();
                }

            }
            else
            {
                LBPortState.Text = "��ѡ�񴮿ڣ�";
            }
        }

        #endregion

        #region ͨ�ô��ڲ���
        //ͨ�ô��ڲ���
        private void btnSend_Click(object sender, EventArgs e)
        {
            string sResult = "";
            sResult = WriteData(txtBoxSend.Text);
            if (sResult != "")
            {
                SetMSG(sResult);
            }

        }
        #endregion

        #region ������յ������ݵ�ί��

        //ί�е�ʵ��
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
                       txtBoxAllReceive.AppendText(s+"   ");
                       SetMSG("�յ�����:" + s);
                   };
                this.Invoke(callALL, text);
            }
            else
            {
                txtBoxAllReceive.AppendText(text);
                SetMSG("�յ�����:" + text);
            }

        }




        #endregion

        #region ���ڽ��������¼���Ӧ
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //bool flag = false;//�Ƿ������������
            //int PackgeLength = 0;//��λ���������ݵ��ܳ��ȡ�
            while (serialPort1.BytesToRead > 0)
            {

                if (isHexShow.Checked)
                {
                    int data = 0x00;
                    try
                    {
                        data = serialPort1.ReadByte();
                    }
                    catch (Exception e2)
                    {
                        // MessageBox.Show(e2.Message);
                        SetMSG(e2.Message);
                        break;
                    }

                    ReceiveData += data.ToString("X").PadLeft(2, '0');
                    ReceiveData = ReceiveData.ToUpper();
                }
                else
                {
                    ReceiveData += serialPort1.ReadExisting();
                }
            }
            safeAddtrText(ReceiveData);//��ʾ���ݵ�ί��
            ReceiveData = "";

        }
        #endregion

        #region ����
        ////���ó��������в�������Ϣ��������־
        //protected void SetMSG(string msg)
        //{
        //    txtBoxMSG.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "��" + msg + "\r\n";
        //    NomalFunction.WriteNomalLog(msg);
        //}

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CLSTxtBoxAllReceive_Click(object sender, EventArgs e)
        {
            txtBoxAllReceive.Text = "";
        }

        //private void txtBoxAllReceive_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtBoxAllReceive.Text.Length > 4096)
        //        txtBoxAllReceive.Text = "";
        //    txtBoxAllReceive.SelectionStart = txtBoxAllReceive.Text.Length + 10;//����ѡ�����ֵĿ�ʼλ��Ϊ�ı�������ֵĳ���
        //    txtBoxAllReceive.SelectionLength = 0;//���ñ�ѡ�����ֵĳ���Ϊ0��������ƶ����������
        //    txtBoxAllReceive.ScrollToCaret();//���������ƶ������λ��
        //}

      
        #endregion

        #region �򴮿ڷ�������
        /// <summary>
        /// �򴮿ڷ�������
        /// </summary>       
        /// <param name="cmd">��Ϊ������</param>
        /// <returns>Ϊ����ִ������������Ϊ�쳣��Ϣ</returns>
        protected string WriteData(string cmd)
        {
            string sResult = "";
            if (serialPort1 == null)
            {
              
                sResult = "����δ��ʼ����";
                return sResult;

            }
            if (!serialPort1.IsOpen)
            {
              
                sResult = "����δ�򿪣����ں�Ϊ��" + serialPort1.PortName;
                return sResult;
            }
            try
            {
                string sendvalue = "";
                sendvalue = cmd;

                if (checkBoxTrimSpace.Checked)
                {
                    sendvalue = sendvalue.Replace(" ", "");
                }


                if (chBoxIsHex.Checked)
                {
                    int sendLength = sendvalue.Length / 2;
                    byte[] StrBuffer = new byte[sendLength];
                    string hexstring = "";
                    int k = 0;
                    for (int i = 0; i < sendvalue.Length; )
                    {
                        try
                        {
                            hexstring = sendvalue.Substring(i, 2);
                        }
                        catch (Exception ex)
                        {
                            sResult += "ʹ��hex�������ݳ������鷢�͵������Ƿ���16���Ƹ�ʽ����ϸ��Ϣ��"+ex.Message;
                            return sResult;
                        }
                        int j;
                        j = int.Parse(hexstring, System.Globalization.NumberStyles.HexNumber);
                        StrBuffer[k] = (byte)j;
                        i += 2;
                        k++;
                    }

                    serialPort1.Write(StrBuffer, 0, StrBuffer.Length);

                }
                else
                {
                    serialPort1.Write(sendvalue);
                    System.Threading.Thread.Sleep(50);//ÿ�η�����ϣ�����50ms
                }
            }
            catch (Exception ex)
            {
                sResult = ex.Message;
            }
            return sResult;
        }
        #endregion



        #region ��Ϣ����־

        /// <summary>
        /// //���ó��������в�������Ϣ��������־
        /// </summary>
        /// <param name="msg">��Ϣ</param>
        protected void SetMSG(string msg)
        {
            ShowMSgDelegate showmsgDelegate = new ShowMSgDelegate(SetmsgDelegateTargetFun);
            if (txtBoxMSG.InvokeRequired)
            {
                txtBoxMSG.BeginInvoke(showmsgDelegate, msg);
            }
            else
            {
                if (txtBoxMSG.Text.Length > 1024 * 512)
                {
                    txtBoxMSG.Text = string.Empty;
                }
                txtBoxMSG.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "��" + msg + "\r\n");
            }
            mu.WaitOne();
            SiXi.Logs.Log.WriteDebugLog(msg);
            mu.ReleaseMutex();
        }
        /// <summary>
        /// ��ʾ��Ϣ��ί�е�Ŀ�꺯��
        /// </summary>
        /// <param name="msg">Ҫ��ʾ����Ϣ</param>
        protected void SetmsgDelegateTargetFun(string msg)
        {
            if (txtBoxMSG.Text.Length > 1024 * 512)
            {
                txtBoxMSG.Text = string.Empty;
            }
            txtBoxMSG.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "��" + msg + "\r\n");
        }
        /// <summary>
        /// //��ʾ���������в������쳣��Ϣ��������־
        /// </summary>
        /// <param name="msg">��Ϣ</param>
        protected void SetExceptionMSG(Exception msg)
        {
            ShowExceptionMSgDelegate showmsgDelegate = new ShowExceptionMSgDelegate(SetExceptionmsgDelegateTargetFun);
            if (txtBoxMSG.InvokeRequired)
            {
                txtBoxMSG.BeginInvoke(showmsgDelegate, msg);
            }
            else
            {
                if (txtBoxMSG.Text.Length > 1024 * 512)
                {
                    txtBoxMSG.Text = string.Empty;
                }
                txtBoxMSG.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "��" + msg.ToString() + "\r\n");
            }
            muExceptionLog.WaitOne();
            SiXi.Logs.Log.WriteDebugLog(msg.ToString());
            muExceptionLog.ReleaseMutex();
        }
        /// <summary>
        /// ��ʾ�쳣��Ϣ��ί�е�Ŀ�꺯��
        /// </summary>
        /// <param name="msg">Ҫ��ʾ����Ϣ</param>
        protected void SetExceptionmsgDelegateTargetFun(Exception msg)
        {
            if (txtBoxMSG.Text.Length > 1024 * 512)
            {
                txtBoxMSG.Text = string.Empty;
            }
            txtBoxMSG.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "��" + msg.ToString() + "\r\n");
        }
        #endregion

        #region �Ҽ��˵�
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abForm = new AboutBox1();
            abForm.ShowDialog();
        }
        #endregion



    }
}