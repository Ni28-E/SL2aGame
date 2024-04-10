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
{ //in the game instead of having the avatar move we will have the obstacles moving towards the avatar and we'll make it look like the avatar is the one actually moving
    public partial class Form1 : Form
    {   
        Random rnd = new Random();//makes a new random classs
        bool isJumping = false; //this variable says when the avatar is jumping or not
        int jumpSpeed = 10; //this variable defines how fast the avatar jumps
        int jumpForce = 12; //this variable defines how high the avatar jumps
        int obstacleSpeed = 10; //this variable defines how fast the obstacles come at the avatar
        int scoreCount = 0;//this variable will track the amount of points the player has obtained


        public Form1()
        {
            InitializeComponent();

            resetGame();//will reset the game
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameEvent(object sender, EventArgs e)
        {
            Avatar.Top += jumpSpeed;

            //shows the score in the score label
            score.Text = "Score: " + scoreCount;

            if (isJumping)
            {
                jumpSpeed = -10;
                jumpForce -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            if(isJumping && jumpForce < 0)//makes it so that you eventually stop going up and fall to the ground
            {
                isJumping = false;
            }

            if (Avatar.Top >= 380 && !isJumping)
            {
                jumpForce = 12;
                Avatar.Top = Floor.Top - Avatar.Height;
                jumpSpeed = 0;
            }
        }

        public void resetGame()
        {   
            Avatar.Top = Floor.Top - Avatar.Height;
            jumpForce = 12;
            isJumping = false;
            scoreCount = 0;


            gameTimer.Start(); //starts the timer
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {   
            //if the space key is pressed then the game will check wether the jumping boolean is set to true
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
            }
        }

        private void keyReleased(object sender, KeyEventArgs e)
        {
            if (isJumping) {//if the key is released and isJumping is set to true then it will be set to false so that the avatar is no longer jumping
                isJumping = false;
            }

            if (e.KeyCode == Keys.Q)//if the q key is pressed and subsequently released then the game will reset
            {
                resetGame();
            }
        }
    }
}
