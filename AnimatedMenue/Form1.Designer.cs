namespace AnimatedMenue
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Label();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.Setting);
            this.panel2.Controls.Add(this.About);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 123);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animated Menu";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Logout.Image = global::AnimatedMenue.Properties.Resources.icons8_logout_64;
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logout.Location = new System.Drawing.Point(416, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 79);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Setting
            // 
            this.Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Setting.Image = global::AnimatedMenue.Properties.Resources.icons8_setting_64;
            this.Setting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Setting.Location = new System.Drawing.Point(315, 0);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(95, 79);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "Setting";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.About.Image = global::AnimatedMenue.Properties.Resources.icons8_about_64;
            this.About.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.About.Location = new System.Drawing.Point(214, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(95, 79);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Home.Image = global::AnimatedMenue.Properties.Resources.icons8_home_64;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home.Location = new System.Drawing.Point(113, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(95, 79);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Dashboard
            // 
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Dashboard.Image = global::AnimatedMenue.Properties.Resources.icons8_dashboard_64__1_;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Dashboard.Location = new System.Drawing.Point(12, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(95, 79);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MenuTimer
            // 
            this.MenuTimer.Enabled = true;
            this.MenuTimer.Interval = 10;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Setting;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Timer MenuTimer;
    }
}

