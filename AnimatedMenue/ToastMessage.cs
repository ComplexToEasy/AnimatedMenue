using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedMenue
{
    public partial class ToastMessage : Form
    {
        private int toastX;
        private int toastY = 0;
        private int targetYposition = 25;
        public ToastMessage()
        {
            InitializeComponent();
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            toastX = screenWidth - this.Width;
            this.Location = new Point(toastX, toastY);
            ToastTimer.Start();
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            if (this.Top < targetYposition)
            {
                toastY++;
                this.Location = new Point(toastX, toastY);

            }
            else if (this.Top > targetYposition)
            {

                ToastTimer.Stop();
                //ta
            }
        }

        private int locY = 0;

        private void ToastHideTimer_Tick(object sender, EventArgs e)
        {
            ToastTimer.Stop();

            locY++;
            TypeLbl.Text = locY.ToString();
            if (locY >= 80)
            {
                toastY--;
                this.Location = new Point(toastX, toastY);
                //this.Close();
                ToastHideTimer.Stop();

            }

        }
    }
}
