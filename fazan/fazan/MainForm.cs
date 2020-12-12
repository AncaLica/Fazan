using fazan.Classes;
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

namespace fazan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        TcpClient client;
        StreamReader StrToReceive;
        StreamWriter StrToWrite;
        string recieve;
        string textToSend;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = GetLocalIPAddress();
            //client = new SimpleTcpClient();
            //client.StringEncoder = Encoding.UTF8;
            //client.DataReceived += Client_DataReceived;
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtHost.Text = ip.ToString(); ;
                    return ip.ToString();
                }
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        //private void Client_DataReceived(object sender, SimpleTCP.Message e)
        //{
        //    txtImportantWord.Invoke((MethodInvoker)delegate ()
        //    {
        //        txtImportantWord.Text = e.MessageString; // afisare cuvant trimis

        //    });
        //}
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            /*---------client----------*/
            if (txtContinuationWord.Text!="")
            {
                textToSend = txtContinuationWord.Text;
            }
            txtContinuationWord.Text = "";
            /*--------------*/

            GameController GC = new GameController();
            GC.SendInput(txtImportantWord.Text+txtContinuationWord.Text);
           
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            client = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(txtHost.Text), int.Parse(txtPort.Text));
            try
            {
                client.Connect(ipEnd);
                if (client.Connected)
                {
                    txtStatus.Text = "Connected to server"+ Environment.NewLine;
                    StrToReceive = new StreamReader(client.GetStream());
                    StrToWrite = new StreamWriter(client.GetStream());
                    StrToWrite.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try {
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
