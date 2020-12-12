using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetLocalIPAddress();
            //server =new SimpleTcpServer();
            //server.Delimiter = 0x13; //enter
            //server.StringEncoder = Encoding.UTF8;
            //server.DataReceived += Server_DataRecived;
        }

        //private void Server_DataRecived(object sender, SimpleTCP.Message e)
        //{
        //    txtStatus.Invoke((MethodInvoker)delegate ()
        //    {
        //        txtStatus.Text += e.MessageString + Environment.NewLine;
        //        e.ReplyLine(string.Format(e.MessageString)); //asta ii ce se trimite
        //    });

        //}
        public  string GetLocalIPAddress() //functie pt a lua ip-ul de pe leptopul tau
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtHost.Text= ip.ToString(); ;
                    return ip.ToString();
                }
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        TcpClient client;
        StreamReader StrToReceive;
        StreamWriter StrToWrite;
        string recieve;
        string textToSend;
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Starting..." + Environment.NewLine;

            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            StrToReceive = new StreamReader(client.GetStream());
            StrToWrite = new StreamWriter(client.GetStream());
            StrToWrite.AutoFlush = true;

           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Stop..." + Environment.NewLine;
            if (server.IsStarted)
                server.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtContinuationWord.Text != "")
            {
                textToSend = txtContinuationWord.Text;
            }
            txtContinuationWord.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = StrToReceive.ReadLine();
                    txtImportantWord.Invoke(new MethodInvoker(delegate ()
                    {
                        txtImportantWord.Text = recieve;
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
