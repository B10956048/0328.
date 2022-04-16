﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace _0328
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UdpClient U;
        Thread Th;
        private void listen()
        {
            int Port = int.Parse(textBox_listen_port.Text);

            U = new UdpClient(Port);//本機端點

            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);//網路端點表示成 IP 位址和連接埠號碼。

            while (true)
            {
                byte[] B = U.Receive(ref EP); //接收訊息放到 B 陣列
                textBox_recive_msg.Text = Encoding.Default.GetString(B); //翻譯 B 陣列為字串
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "我的ip:" + MyIP();
        }

        private void button_start_listen_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //忽略跨執行續錯誤
            Th = new Thread(listen); //建立監聽執行續，目標副程式 -> Listen
            Th.Start(); //啟動監聽執行續
            button_start_listen.Enabled = false; //使 Button 失效(不能重複開啟監聽)
        }
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            try
            {
                Th.Abort(); //關閉監聽執行續
                U.Close(); //關閉監聽器
            }
            catch
            {
                //忽略錯誤
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string IP = textBox_target_IP.Text;
            int Port = int.Parse(textBox_target_port.Text);
            byte[] B = Encoding.Default.GetBytes(textBox_send.Text);
            UdpClient S = new UdpClient();
            S.Send(B, B.Length, IP, Port);
            S.Close();
        }
        private string MyIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hostname).AddressList;

            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork && it.ToString() != "192.168.56.1")
                {
                    return it.ToString();
                }
            }
            return "";
        }
    }
}
