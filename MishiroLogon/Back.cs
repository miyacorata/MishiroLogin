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
    }
}
