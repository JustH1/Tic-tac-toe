using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crosses_and_zeros.Properties;

namespace Crosses_and_zeros
{    
    public partial class Login : Form
    {
        Point moveStart;
        public Login()
        {
            InitializeComponent();
            this.Icon = Resources.Icon;
            this.Size = new Size(300, 300);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = Resources.X_for_login;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Resources._0_for_login;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;           
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                this.Hide();
                Tic_tac_toe game = new Tic_tac_toe(textBox1.Text, textBox2.Text);
                game.Show();
            }
            else
            {
                MessageBox.Show("Error! Enter the names of the players.");                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point point = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + point.X, this.Location.Y + point.Y);
            }
        }
    }
}
