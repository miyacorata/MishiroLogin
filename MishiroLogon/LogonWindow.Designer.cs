namespace MishiroLogon
{
    partial class Logon
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.CancButton = new System.Windows.Forms.Button();
            this.LogonButton = new System.Windows.Forms.Button();
            this.LogonPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(12, 167);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(95, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "ユーザー名(&U)";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 201);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(94, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "パスワード(&P)";
            // 
            // UserTextbox
            // 
            this.UserTextbox.Location = new System.Drawing.Point(113, 164);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(410, 27);
            this.UserTextbox.TabIndex = 3;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(113, 198);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(410, 27);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // CancButton
            // 
            this.CancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancButton.Location = new System.Drawing.Point(528, 253);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(100, 26);
            this.CancButton.TabIndex = 5;
            this.CancButton.Text = "キャンセル";
            this.CancButton.UseVisualStyleBackColor = true;
            this.CancButton.Click += new System.EventHandler(this.CancButton_Click);
            // 
            // LogonButton
            // 
            this.LogonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LogonButton.Location = new System.Drawing.Point(422, 253);
            this.LogonButton.Name = "LogonButton";
            this.LogonButton.Size = new System.Drawing.Size(100, 26);
            this.LogonButton.TabIndex = 6;
            this.LogonButton.Text = "OK";
            this.LogonButton.UseVisualStyleBackColor = true;
            this.LogonButton.Click += new System.EventHandler(this.LogonButton_Click);
            // 
            // LogonPic
            // 
            this.LogonPic.Image = global::MishiroLogon.Properties.Resources._346logon;
            this.LogonPic.Location = new System.Drawing.Point(0, 0);
            this.LogonPic.Name = "LogonPic";
            this.LogonPic.Size = new System.Drawing.Size(640, 150);
            this.LogonPic.TabIndex = 0;
            this.LogonPic.TabStop = false;
            // 
            // Logon
            // 
            this.AcceptButton = this.LogonButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.CancButton;
            this.ClientSize = new System.Drawing.Size(640, 291);
            this.ControlBox = false;
            this.Controls.Add(this.LogonButton);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LogonPic);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログオン";
            ((System.ComponentModel.ISupportInitialize)(this.LogonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogonPic;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button CancButton;
        private System.Windows.Forms.Button LogonButton;
    }
}

