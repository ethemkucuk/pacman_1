using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hareket(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: pacman.Left -= 10; break;
                case Keys.Right: pacman.Left += 10; break;
                case Keys.Up: pacman.Top -= 10; break;
                case Keys.Down: pacman.Top += 10; break;


            }
        }
    }
}
