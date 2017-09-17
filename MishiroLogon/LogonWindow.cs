using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace MishiroLogon
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private bool VerifyLogon(string user,string pswd)
        {
            AppSettingsReader reader = new AppSettingsReader();

            //設定ファイルの読み込み
            string username = (string)reader.GetValue("Username", typeof(string));
            string password = (string)reader.GetValue("Password", typeof(string));

            if (username != user || password != pswd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            //検証
            if (VerifyLogon(UserTextbox.Text,PasswordTextbox.Text))
            {
                MessageBox.Show("ユーザー名かパスワードが不正です。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextbox.Text = string.Empty;
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else
            {
                Application.Exit();
            }
        }

        private void CancButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ログインが必要です。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }
    }
}
