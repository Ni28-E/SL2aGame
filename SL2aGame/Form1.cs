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
        int jumpForce = 10; //this variable defines how high the avatar jumps
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

        }

        private void downAction(object sender, KeyEventArgs e)
        {

        }

        private void upAction(object sender, KeyEventArgs e)
        {

        }

        public void resetGame()
        {

        }
    }
}
