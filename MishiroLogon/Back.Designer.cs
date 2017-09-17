namespace MishiroLogon
{
    partial class Back
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Back));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClockLabel = new System.Windows.Forms.Label();
            this.MishiroLabel = new System.Windows.Forms.Label();
            this.ClockSecLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockLabel
            // 
            resources.ApplyResources(this.ClockLabel, "ClockLabel");
            this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockLabel.ForeColor = System.Drawing.Color.White;
            this.ClockLabel.Name = "ClockLabel";
            // 
            // MishiroLabel
            // 
            resources.ApplyResources(this.MishiroLabel, "MishiroLabel");
            this.MishiroLabel.BackColor = System.Drawing.Color.Transparent;
            this.MishiroLabel.ForeColor = System.Drawing.Color.White;
            this.MishiroLabel.Name = "MishiroLabel";
            // 
            // ClockSecLabel
            // 
            resources.ApplyResources(this.ClockSecLabel, "ClockSecLabel");
            this.ClockSecLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockSecLabel.ForeColor = System.Drawing.Color.White;
            this.ClockSecLabel.Name = "ClockSecLabel";
            // 
            // Back
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MishiroLogon.Properties.Resources.Pegasus;
            this.Controls.Add(this.ClockSecLabel);
            this.Controls.Add(this.MishiroLabel);
            this.Controls.Add(this.ClockLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Back";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Back_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Label MishiroLabel;
        private System.Windows.Forms.Label ClockSecLabel;
    }
}