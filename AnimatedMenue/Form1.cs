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
    public partial class Form1 : Form
    {
        //Collection of menu Labels
        List<Label> menu;
        private int targetYPosition = 25;
        private int animationSpeed = 1;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            menu = new List<Label>(){ Dashboard, Home, About, Setting, Logout };
            AttachMenuHandeler(menu);
        }
        //Attach 
        private void AttachMenuHandeler(List<Label> menu)
        {
            foreach (var label in menu)
            {
                label.Hide();

                label.MouseHover += Lable_Mousehover;
                label.MouseLeave += Lable_MouseLeave;
            }
        }

        private void Lable_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.DarkGray;
        }

        private void Lable_Mousehover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.BlueViolet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            Label currentMenu = menu[currentIndex];
            if (currentMenu.Top < targetYPosition)
            {
                currentMenu.Top += Convert.ToInt32(animationSpeed);
                currentMenu.Show();
            }
            else if (currentMenu.Top > targetYPosition)
            {
                currentMenu.Top -= Convert.ToInt32(animationSpeed);
            }
            else
            {
                currentIndex++;
                if (currentIndex >= menu.Count)
                {
                    MenuTimer.Stop();
                }
                else
                {
                    MenuTimer.Start();
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
