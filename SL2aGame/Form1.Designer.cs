namespace SL2aGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Floor = new System.Windows.Forms.PictureBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.Black;
            this.Floor.Location = new System.Drawing.Point(-12, 452);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(652, 23);
            this.Floor.TabIndex = 0;
            this.Floor.TabStop = false;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.Avatar.Image = global::SL2aGame.Properties.Resources.Avatar;
            this.Avatar.Location = new System.Drawing.Point(46, 405);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(24, 48);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(13, 13);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(76, 20);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SL2aGame.Properties.Resources.obstacle_hydrant;
            this.pictureBox1.Location = new System.Drawing.Point(261, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SL2aGame.Properties.Resources.obstacle_berrybush;
            this.pictureBox2.Location = new System.Drawing.Point(421, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Avatar);
            this.Name = "Form1";
            this.Text = "SL2aGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyReleased);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Floor;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

