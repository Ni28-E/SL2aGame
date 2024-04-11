using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL2aGame
{ 
    //in the game instead of having the avatar move we will have the obstacles moving towards the avatar and
    //we'll make it look like the avatar is the one actually moving
    public partial class Form1 : Form
    {   
        Random rnd = new Random(); //makes a new random classs
        bool isJumping = false; //this variable says when the avatar is jumping or not
        int jumpSpeed = 10; //this variable defines how fast the avatar jumps
        int jumpForce = 12; //this variable defines how high the avatar jumps
        int obstacleSpeed = 10; //this variable defines how fast the obstacles come at the avatar
        int scoreCount = 0; //this variable will track the amount of points the player has obtained
        int position;
        bool gameOver = false;


        public Form1()
        {
            InitializeComponent();

            resetGame(); //will reset the game
        }

        // This function checks for user and object states. -B
        private void gameEvent(object sender, EventArgs e)
        {
            Avatar.Top += jumpSpeed;
            scoreText.Text = "Score: " + scoreCount;//shows the score in the score label

            // Check for jump. -B
            if (isJumping == true && jumpForce < 0) //makes it so that you eventually stop going up and fall to the ground
            {
                isJumping = false;
            }

            // Put jumpSpeed to negative to lower user's playable character. -B
            if (isJumping == true)
            {
                jumpSpeed = -12;
                jumpForce -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            // Set jump to default. -B
            if (Avatar.Top > 405 && isJumping == false)
            {
                jumpForce = 12;
                Avatar.Top = 405;
                jumpSpeed = 0;
            }

            foreach(Control i in this.Controls)
            {
                if(i is PictureBox && (string)i.Tag == "obstacle")
                {
                    // Check if obstacles are out of users screen on the left to respawn them offscreen on the right & add score. -B
                    i.Left -= obstacleSpeed;
                    if(i.Left < -100)
                    {
                        i.Left = this.ClientSize.Width + rnd.Next(200, 500) + (i.Width * 15);
                        scoreCount++;
                    }

                    // Collision check for Avatar & obstacles. -B
                    if(Avatar.Bounds.IntersectsWith(i.Bounds))
                    {
                        gameTimer.Stop();
                        Avatar.Image = Properties.Resources.avatar_dead;
                        scoreText.Text += " Press R to restart.";
                        gameOver = true;
                    }
                }
            }

            // Increase the speed of obstacles to make the game harder. -B
            switch (scoreCount)
            { 
                case 10:
                    obstacleSpeed = 12;
                    break;
                case 15:
                    obstacleSpeed = 13;
                    break;
                case 20:
                    obstacleSpeed = 14;
                    break;
                case 25:
                    obstacleSpeed = 15;
                    break;
                case 30:
                    obstacleSpeed = 16;
                    break;
                case 35:
                    obstacleSpeed = 17;
                    break;
                case 40:
                    obstacleSpeed = 18;
                    break;
                case 45:
                    obstacleSpeed = 19;
                    break;
                case 50:
                    obstacleSpeed = 20;
                    break;
            }
        }

        // This function checks if the user is allowed to jump based on the correct conditions. -B
        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && isJumping == false)
            {
                isJumping = true;
            }
        }

        // This function resets the user's jump state. -B
        // When the user is game over and presses the correct button it'll call resetGame function. -B
        private void KeyReleased(object sender, KeyEventArgs e)
        {
            if (isJumping == true)
            {
                isJumping = false;
            }

            if (e.KeyCode == Keys.R && gameOver == true)
            {
                resetGame();
            }
        }

        // This function resets the game back to its booting state. -B
        public void resetGame()
        {
            jumpForce = 10;
            jumpSpeed = 0;
            isJumping = false;
            scoreCount = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + scoreCount;
            Avatar.Image = Properties.Resources.Avatar;
            gameOver = false;
            Avatar.Top = 405;

            // Spawn obstacles far out of users screen. -B
            foreach(Control i in this.Controls)
            {
                if(i is PictureBox && (string)i.Tag == "obstacle")
                {
                   position = this.ClientSize.Width + rnd.Next(500, 800) + (i.Width * 10);

                    i.Left = position;
                }
            }

            gameTimer.Start();
        }

        
    }
}
