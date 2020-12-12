using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            server =new SimpleTcpServer();
            server.Delimiter = 0x13; //enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataRecived;
        }

        private void Server_DataRecived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Tu ai spus: {0}", e.MessageString));
            });

        }
        public  string GetLocalIPAddress()
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Starting...";
            
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(GetLocalIPAddress());
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
