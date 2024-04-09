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
            this.Floor = new System.Windows.Forms.PictureBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
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
            this.Avatar.BackColor = System.Drawing.Color.Gray;
            this.Avatar.Location = new System.Drawing.Point(131, 386);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(44, 60);
            this.Avatar.TabIndex = 1;
            this.Avatar.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(13, 13);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(76, 20);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.Floor);
            this.Name = "Form1";
            this.Text = "SL2aGame";
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Floor;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label score;
    }
}

