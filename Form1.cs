using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        int turn = 1;
        int allTurns = 0;
        int[,] array1 = new int[3,3];
        int player1Score = 0;
        int player2Score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }



        public void CheckWinner()
        {
            //   2 = X | 1 = O
            if (array1[0,0] == 1 && array1[0,1] == 1 && array1[0,2] == 1 ||
                array1[1, 0] == 1 && array1[1, 1] == 1 && array1[1, 2] == 1 ||
                array1[2, 0] == 1 && array1[2, 1] == 1 && array1[2, 2] == 1 ||
                array1[0, 0] == 1 && array1[1, 1] == 1 && array1[2, 2] == 1 ||
                array1[2, 0] == 1 && array1[1, 1] == 1 && array1[0, 2] == 1 ||
                array1[0, 0] == 1 && array1[1, 0] == 1 && array1[2, 0] == 1 ||
                array1[0, 1] == 1 && array1[1, 1] == 1 && array1[2, 1] == 1 ||
                array1[0, 2] == 1 && array1[1, 2] == 1 && array1[2, 2] == 1)
            {
                MessageBox.Show("player 'O' wins!");
                this.pic1.Click -= new System.EventHandler(this.pic1_Click);
                this.pic2.Click -= new System.EventHandler(this.pic2_Click);
                this.pic3.Click -= new System.EventHandler(this.pic3_Click);
                this.pic4.Click -= new System.EventHandler(this.pic4_Click);
                this.pic5.Click -= new System.EventHandler(this.pic5_Click);
                this.pic6.Click -= new System.EventHandler(this.pic6_Click);
                this.pic7.Click -= new System.EventHandler(this.pic7_Click);
                this.pic8.Click -= new System.EventHandler(this.pic8_Click);
                this.pic9.Click -= new System.EventHandler(this.pic9_Click);
                player1Score++;
                if(player1Score == 3)
                {
                    MessageBox.Show("congratulations! You are the tic tac toe champ Player 1!");
                }
            }
            else if (array1[0, 0] == 2 && array1[0, 1] == 2 && array1[0, 2] == 2 ||
                array1[1, 0] == 2 && array1[1, 1] == 2 && array1[1, 2] == 2 ||
                array1[2, 0] == 2 && array1[2, 1] == 2 && array1[2, 2] == 2 ||
                array1[0, 0] == 2 && array1[1, 1] == 2 && array1[2, 2] == 2 ||
                array1[2, 0] == 2 && array1[1, 1] == 2 && array1[0, 2] == 2 ||
                array1[0, 0] == 2 && array1[1, 0] == 2 && array1[2, 0] == 2 ||
                array1[0, 1] == 2 && array1[1, 1] == 2 && array1[2, 1] == 2 ||
                array1[0, 2] == 2 && array1[1, 2] == 2 && array1[2, 2] == 2)
            {
                MessageBox.Show("player 'X' wins!");
                this.pic1.Click -= new System.EventHandler(this.pic1_Click);
                this.pic2.Click -= new System.EventHandler(this.pic2_Click);
                this.pic3.Click -= new System.EventHandler(this.pic3_Click);
                this.pic4.Click -= new System.EventHandler(this.pic4_Click);
                this.pic5.Click -= new System.EventHandler(this.pic5_Click);
                this.pic6.Click -= new System.EventHandler(this.pic6_Click);
                this.pic7.Click -= new System.EventHandler(this.pic7_Click);
                this.pic8.Click -= new System.EventHandler(this.pic8_Click);
                this.pic9.Click -= new System.EventHandler(this.pic9_Click);
                player2Score++;
                if (player2Score == 3)
                {
                    MessageBox.Show("congratulations! You are the tic tac toe champ Player 2!");
                }
            }
            else
            {
                if (allTurns == 9)
                {
                    MessageBox.Show("Tie try again");
                    this.pic1.Click -= new System.EventHandler(this.pic1_Click);
                    this.pic2.Click -= new System.EventHandler(this.pic2_Click);
                    this.pic3.Click -= new System.EventHandler(this.pic3_Click);
                    this.pic4.Click -= new System.EventHandler(this.pic4_Click);
                    this.pic5.Click -= new System.EventHandler(this.pic5_Click);
                    this.pic6.Click -= new System.EventHandler(this.pic6_Click);
                    this.pic7.Click -= new System.EventHandler(this.pic7_Click);
                    this.pic8.Click -= new System.EventHandler(this.pic8_Click);
                    this.pic9.Click -= new System.EventHandler(this.pic9_Click);
                    
                }
            }
        }

        public void NewGame()
        {
            turn = 1;
            allTurns = 0;
            
            pic1.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic2.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic3.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic4.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic5.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic6.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic7.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic8.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            pic9.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\jeff.jpg");
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            this.pic5.Click += new System.EventHandler(this.pic5_Click);
            this.pic6.Click += new System.EventHandler(this.pic6_Click);
            this.pic7.Click += new System.EventHandler(this.pic7_Click);
            this.pic8.Click += new System.EventHandler(this.pic8_Click);
            this.pic9.Click += new System.EventHandler(this.pic9_Click);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = 0;
                }
            }
            if(player1Score == 3 || player2Score == 3)
            {
                player1Score = 0;
                player2Score = 0;
            }

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            if(turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic1.Click -= new System.EventHandler(this.pic1_Click);   //this is how you reinable the click:     this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
                pic1.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[0,0] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();

                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic1.Click -= new System.EventHandler(this.pic1_Click);
                pic1.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[0,0] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic2.Click -= new System.EventHandler(this.pic2_Click);
                pic2.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[0,1] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic2.Click -= new System.EventHandler(this.pic2_Click);
                pic2.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[0,1] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic3.Click -= new System.EventHandler(this.pic3_Click);
                pic3.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[0,2] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic3.Click -= new System.EventHandler(this.pic3_Click);
                pic3.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[0,2] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic4.Click -= new System.EventHandler(this.pic4_Click);
                pic4.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[1,0] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic4.Click -= new System.EventHandler(this.pic4_Click);
                pic4.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[1,0] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic5.Click -= new System.EventHandler(this.pic5_Click);
                pic5.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[1,1] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic5.Click -= new System.EventHandler(this.pic5_Click);
                pic5.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                //set array value
                array1[1, 1] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic6.Click -= new System.EventHandler(this.pic6_Click);
                pic6.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                //set array value
                array1[1,2] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic6.Click -= new System.EventHandler(this.pic6_Click);
                pic6.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                //set array value
                array1[1,2] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic7.Click -= new System.EventHandler(this.pic7_Click);
                pic7.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[2,0] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic7.Click -= new System.EventHandler(this.pic7_Click);
                pic7.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[2,0]= 1;
                allTurns++;
                turn++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                pic8.Click -= new System.EventHandler(this.pic8_Click);
                pic8.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[2,1] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                this.pic8.Click -= new System.EventHandler(this.pic8_Click);
                pic8.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[2,1] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                //disable the pic that was clicked
                this.pic9.Click -= new System.EventHandler(this.pic9_Click);
                pic9.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\X.png");
                array1[2,2] = 2;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
            else
            {
                //disable the pic that was clicked
                pic9.Click -= new System.EventHandler(this.pic9_Click);
                pic9.Image = Image.FromFile("C:\\TOOLS\\TTT\\Pics\\O.png");
                array1[2,2] = 1;
                turn++;
                allTurns++;
                
                if (allTurns > 4)
                {
                    CheckWinner();
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
            this.Hide();
        }

        
    }
}
