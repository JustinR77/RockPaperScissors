using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            //Assign pictures to random number
            switch(computerTurn)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\river\Downloads\zoltan-tasi-QxjEi8Fs9Hg-unsplash.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\river\Downloads\dan-cristian-padure-izq7BRX6xfw-unsplash.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\river\Downloads\everyday-basics-i0ROGKijuek-unsplash.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\river\Downloads\zoltan-tasi-QxjEi8Fs9Hg-unsplash.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            //Assign pictures to random number
            switch(playerTurn)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\river\Downloads\zoltan-tasi-QxjEi8Fs9Hg-unsplash.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\river\Downloads\dan-cristian-padure-izq7BRX6xfw-unsplash.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\river\Downloads\everyday-basics-i0ROGKijuek-unsplash.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\river\Downloads\zoltan-tasi-QxjEi8Fs9Hg-unsplash.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            determineWinner(computerTurn, playerTurn);
        }

        public void determineWinner(int computerScore, int playerScore)
        {
            if(computerScore == 1 && playerScore == 2)
            {
                label1.Text = "You win!";
            }
            else if(computerScore == 1 && playerScore == 3)
            {
                label1.Text = "Computer Wins!";
            }
            else if(computerScore == 2 && playerScore == 1)
            {
                label1.Text = "Computer Wins!";
            }
            else if(computerScore == 2 && playerScore == 3)
            {
                label1.Text = "You win!";
            }
            else if(computerScore == 3 && playerScore == 2)
            {
                label1.Text = "You win!";
            }
            else if(computerScore == 3 && playerScore == 2)
            {
                label1.Text = "Computer Wins!";
            }
            else
            {
                label1.Text = "There's a tie!";
            }
        }
    }
}
