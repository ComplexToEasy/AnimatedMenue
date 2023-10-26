namespace AnimatedMenue
{
    partial class ToastMessage
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
            this.TypeLbl = new System.Windows.Forms.Label();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToastTimer = new System.Windows.Forms.Timer(this.components);
            this.ToastHideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TypeLbl.Location = new System.Drawing.Point(61, 8);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(47, 20);
            this.TypeLbl.TabIndex = 0;
            this.TypeLbl.Text = "Type";
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MessageLbl.Location = new System.Drawing.Point(63, 30);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(64, 16);
            this.MessageLbl.TabIndex = 1;
            this.MessageLbl.Text = "Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimatedMenue.Properties.Resources.icons8_success_64;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-17, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 36);
            this.panel1.TabIndex = 3;
            // 
            // ToastTimer
            // 
            this.ToastTimer.Enabled = true;
            this.ToastTimer.Interval = 10;
            this.ToastTimer.Tick += new System.EventHandler(this.ToastTimer_Tick);
            // 
            // ToastHideTimer
            // 
            this.ToastHideTimer.Enabled = true;
            this.ToastHideTimer.Interval = 10;
            this.ToastHideTimer.Tick += new System.EventHandler(this.ToastHideTimer_Tick);
            // 
            // ToastMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 49);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.TypeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastMessage";
            this.Text = "ToastMessage";
            this.Load += new System.EventHandler(this.ToastMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer ToastTimer;
        private System.Windows.Forms.Timer ToastHideTimer;
    }
}