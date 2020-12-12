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
                e.ReplyLine(string.Format(e.MessageString)); //asta se trimite la client
            });

        }
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Starting..." + Environment.NewLine;

            MainFormServer MFS = new MainFormServer();
            MFS.Show();

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(GetLocalIPAddress());
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Server Stop..." + Environment.NewLine;
            if (server.IsStarted)
                server.Stop();
        }
    }
}
