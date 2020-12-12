using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazan
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

       private void btnStartJoc_Click(object sender, EventArgs e)
        {
            btnStartJoc.Enabled = false;

            MainForm Mf = new MainForm();
            Mf.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            info inf = new info();
            inf.Show();
        }

        private void btnReguli_Click(object sender, EventArgs e)
        {
            reguliJoc reg = new reguliJoc();
            reg.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
           
        }


    }
}
