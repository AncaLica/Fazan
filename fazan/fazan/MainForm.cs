using fazan.Classes;
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

namespace fazan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = GetLocalIPAddress();
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
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
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtImportantWord.Invoke((MethodInvoker)delegate ()
            {
                txtImportantWord.Text += e.MessageString;

            });
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            /*---------client----------*/
            client.Connect(txtHost.Text,Convert.ToInt32(txtPort.Text));
            client.WriteLineAndGetReply(txtContinuationWord.Text,TimeSpan.FromSeconds(3));


            /*--------------*/

            GameController GC = new GameController();
            GC.SendInput(txtImportantWord.Text+txtContinuationWord.Text);
           
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
        }
    }
}
