using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MishiroLogon
{
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        public void ShowLogon()
        {
            Form logon = new Logon();
            logon.ShowDialog(this);
        }

        private void Back_Load(object sender, EventArgs e)
        {
            this.ShowLogon();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            string minuteStr = datetime.Minute.ToString();
            if (datetime.Minute < 10) minuteStr = "0" + minuteStr;
            string secondStr = datetime.Second.ToString();
            if (datetime.Second < 10) secondStr = "0" + secondStr;
            ClockLabel.Text = datetime.Hour.ToString() + ":" + minuteStr;
            ClockSecLabel.Text = secondStr;
        }
    }
}
