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
using System.Collections;
using System.Text.RegularExpressions;

namespace CG内效工具_量产程序测试上位机
{
    public partial class Form1 : Form
    {
        private SerialPort ComDevice = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Baud_Rate_String_Array = { "2400","4800", "9600", "14400", "19200", "38400", "56000", "115200", "256000"};
            串口号_comboBox.Items.AddRange(SerialPort.GetPortNames());
            if (串口号_comboBox.Items.Count > 0)
            {
                串口号_comboBox.SelectedIndex = 0;
            }

            波特率_comboBox.Items.AddRange(Baud_Rate_String_Array);
            波特率_comboBox.SelectedIndex = 7;


            //向ComDevice.DataReceived（是一个事件）注册一个方法Com_DataReceived，当端口类接收到信息时时会自动调用Com_DataReceived方法
            ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
        }

        private void 刷新串口_button_Click(object sender, EventArgs e)
        {
            串口号_comboBox.Items.Clear();
            串口号_comboBox.Items.AddRange(SerialPort.GetPortNames());
            if (串口号_comboBox.Items.Count > 0)
            {
                串口号_comboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 一旦ComDevice.DataReceived事件发生，就将从串口接收到的数据显示到接收端对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开辟接收缓冲区
            byte[] ReDatas = new byte[ComDevice.BytesToRead];

            //从串口读取数据
            ComDevice.Read(ReDatas, 0, ReDatas.Length);
            
            // 如果接收框为HEX显示
            if(HEX显示_checkBox.Checked==true)
            {
                foreach (byte byte_data in ReDatas)
                {
                    // 将数据转为HEX格式并添加到接收框
                    Action<String> AsyncUIDelegate = delegate (string n) { 接收数据_textBox.Text = n; };
                    接收数据_textBox.Invoke(AsyncUIDelegate, new object[] { 接收数据_textBox.Text + Convert.ToString(byte_data, 16) + " " });
                }
            }
            // 如果为文本显示
            else
            {
                // 将byte[]转为string并添加到接收框
                Action<String> AsyncUIDelegate = delegate (string n) { 接收数据_textBox.Text = n; };
                接收数据_textBox.Invoke(AsyncUIDelegate, new object[] { 接收数据_textBox.Text + Encoding.Default.GetString(ReDatas) });
            }

        }

        private void 发送_button_Click(object sender, EventArgs e)
        {
            byte[] command_byte_array;
            byte[] data_byte_array;
           
            if(打开串口_button.Text=="关闭串口")
            {

                if (使能命令字段_checkBox.Checked == true)
                {
                    if (命令字段HEX_checkBox.Checked == true)
                    {
                        command_byte_array = Hex_String_To_Byte_Array(命令字段_textBox.Text);

                    }
                    else
                    {
                        command_byte_array = Encoding.UTF8.GetBytes(命令字段_textBox.Text);
                    }
                }
                else
                {
                    command_byte_array = null;
                }

                if (使能数据字段_checkBox.Checked == true)
                {
                    if (数据字段HEX_checkBox.Checked == true)
                    {
                        data_byte_array = Hex_String_To_Byte_Array(数据字段_textBox.Text);

                    }
                    else
                    {
                        data_byte_array = Encoding.UTF8.GetBytes(数据字段_textBox.Text);
                    }
                }
                else
                {
                    data_byte_array = null;
                }


                // 生成CG格式的量产测试数据包
                byte[] CG_datapacket_byte_array = Get_CG_Test_DataPacket(command_byte_array, data_byte_array);


                // 串口发送数据
                ComDevice.Write(CG_datapacket_byte_array, 0, CG_datapacket_byte_array.Length);

            }
            else
            {
                MessageBox.Show("请先打开串口", "Error");
            }


        }

        //  十六进制string转byte[]
        private byte[] Hex_String_To_Byte_Array(string hex_string)
        {
            ArrayList byte_array_list = new ArrayList();

            // 用空格做文本分割
            string[] sArray = Regex.Split(hex_string, " ", RegexOptions.IgnoreCase);

            foreach (string i in sArray)
            {
                byte_array_list.Add(System.Convert.ToByte(i, 16));
            }

            return (Byte[])byte_array_list.ToArray(typeof(Byte));

        }




        // 生成CG量产测试数据包
        private byte[] Get_CG_Test_DataPacket(byte[] command_byte_array,byte[] data_byte_array)
        {
            ArrayList Send_Data_list = new ArrayList();

            // 添加包头
            foreach (byte tmp_byte in Encoding.Default.GetBytes("CG"))
            {
                Send_Data_list.Add(tmp_byte);
            }

            if (command_byte_array.Length > 0)
            {
                // 添加命令部分的长度
                Send_Data_list.Add((byte)command_byte_array.Length);

            }
            else
            {
                // 添加命令部分的长度
                foreach (byte tmp_byte in BitConverter.GetBytes((ushort)0))
                {
                    Send_Data_list.Add(tmp_byte);
                }
            }

            if(command_byte_array.Length>0)
            {
                // 添加命令部分
                foreach (byte tmp_byte in command_byte_array)
                {
                    Send_Data_list.Add(tmp_byte);
                }
            }

            if (data_byte_array.Length > 0)
            {
                // 添加数据部分
                foreach (byte tmp_byte in data_byte_array)
                {
                    Send_Data_list.Add(tmp_byte);
                }
            }

            ushort DataPacket_DataSun=0;

            byte[] tmp_datapacket_byte_array = (Byte[])Send_Data_list.ToArray(typeof(Byte));

            // 计算校验和
            foreach (byte byte_Data in tmp_datapacket_byte_array)
            {
                DataPacket_DataSun = (ushort)(DataPacket_DataSun + (ushort)byte_Data);
            }

            // 添加校验和
            Send_Data_list.Add(BitConverter.GetBytes(DataPacket_DataSun)[1]);
            Send_Data_list.Add(BitConverter.GetBytes(DataPacket_DataSun)[0]);


            // 强制转换为数组
            byte[] send_data_byte_array = (Byte[])Send_Data_list.ToArray(typeof(Byte));
            return send_data_byte_array;
        }

        private void 打开串口_button_Click(object sender, EventArgs e)
        {
            if(打开串口_button.Text=="打开串口")
            {
                try
                {
                    ComDevice.PortName = 串口号_comboBox.Text;

                    // 配置串口波特率
                    ComDevice.BaudRate = int.Parse(波特率_comboBox.Text);

                    // 配置无校验
                    ComDevice.Parity = Parity.None;

                    // 8bit
                    ComDevice.DataBits = 8;

                    // 1个停止位
                    ComDevice.StopBits = StopBits.One;

                    // 数据接收超时时间(ms)
                    ComDevice.ReadTimeout = 100;

                    // 如果打开状态，则先关闭一下
                    if (ComDevice.IsOpen == true)
                    {
                        ComDevice.Close();
                    }

                    // 打开串口
                    ComDevice.Open();

                    打开串口_button.Text = "关闭串口";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else if(打开串口_button.Text=="关闭串口")
            {
                if (ComDevice.IsOpen == true)
                {
                    ComDevice.Close();
                }

                打开串口_button.Text = "打开串口";
            }
            



        }
    }
}
