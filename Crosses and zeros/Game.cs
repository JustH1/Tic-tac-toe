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
    public partial class Tic_tac_toe : Form
    {
        string whoPlay = "";
        string pl1;
        string pl2;
        Point StartPoint;
        public Tic_tac_toe(string pl1, string pl2)
        {
            this.pl1 = whoPlay = pl1;
            this.pl2 = pl2;
            InitializeComponent();
            this.Text = "Crosses and zeros =)";
            this.Icon = Resources.Icon;           
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            label3.Text = $"The first move makes: {pl1}";
            buttonClose.Text = "Close";
            buttonRes.Text = "Restart";
        }               
        private void Bt_Click(object sender, EventArgs e)
        {
            Button buttonCl = sender as Button;
            if (buttonCl.Text != "")
            {
                MessageBox.Show("Position occupied");
            }
            else
            {                
                if (whoPlay == pl1)
                {
                    buttonCl.Text = "X";
                    whoPlay = pl2;
                    label3.Text = $"Next move: {pl1}";
                    CheckWin();
                }
                else
                {
                    buttonCl.Text = "0";
                    whoPlay = pl1;
                    label3.Text = $"Next move: {pl2}";
                    CheckWin();
                }   
            }            
        }
        private void CheckWin()
        {
            if (button0.Text == button1.Text && button1.Text == button2.Text)                 
            {
                if(button1.Text != "")
                {
                    MessageBox.Show($"The player won: {whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }
                
            }
            else if (button3.Text == button4.Text && button4.Text == button5.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show($"The player won:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                } 
            }
            else if (button6.Text == button7.Text && button7.Text == button8.Text)
            {
                if (button7.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }               
            }
            else if (button0.Text == button3.Text && button3.Text == button6.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }               
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if(button4.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }   
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button5.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }
            }
            else if (button0.Text == button4.Text && button4.Text == button8.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }
            }
            else if (button2.Text == button4.Text && button4.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show($"Победил игрок:{whoPlay}");
                    this.Close();
                    Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
                    game.Show();
                }
            }
        }              
        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tic_tac_toe game = new Tic_tac_toe(pl1, pl2);
            game.Show();
        }

        private void Tic_tac_toe_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point point = new Point(e.X - StartPoint.X, e.Y - StartPoint.Y);
                this.Location = new Point(this.Location.X + point.X, this.Location.Y + point.Y);
            }          
        }

        private void Tic_tac_toe_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StartPoint = new Point(e.X, e.Y);
            }
        }
    }
}
