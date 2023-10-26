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
    public partial class Form2 : Form
    {
        private List<Label> menu;
        public Form2()
        {
            InitializeComponent();
            menu = new List<Label>(){ Dashboard, Home, About, Setting, Logout };
            AttachMenuHandler(menu);
        }

        private int targetMenuYPosition = 5;
        private int animationSpeed = 1;
        private int currentIndex = 0;
        private void AttachMenuHandler(List<Label> menu)
        {
            foreach (var label in menu)
            {
                label.Hide();
                label.MouseHover += user_Mousehover;
                label.MouseLeave += user_Mouseleave;

            }
        }

        private void user_Mouseleave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(118, 181, 197);
            ((Label)sender).ForeColor = Color.Black;

        }

        private void user_Mousehover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(89, 98, 151);
            ((Label)sender).ForeColor = Color.White;

            //118, 181, 197
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            Label currentMenu = menu[this.currentIndex];

            if (currentMenu.Top < targetMenuYPosition)
            {
                currentMenu.Top += animationSpeed;
                currentMenu.Show();
            }
            else if (currentMenu.Top > targetMenuYPosition)
            {
                currentMenu.Top -= animationSpeed;
                currentMenu.Show();

            }
            else
            {
                currentIndex++;
                if (menu.Count <= currentIndex)
                {
                    MenuTimer.Stop();
                }
                else
                {
                    MenuTimer.Start();
                }
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ToastMessage t = new ToastMessage();
            t.Show();
        }
    }
}
