namespace TRex
{
    partial class TRexMainClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRexMainClass));
            this.FloorPictureBox = new System.Windows.Forms.PictureBox();
            this.trexPictureBox = new System.Windows.Forms.PictureBox();
            this.obstacle1PictureBox = new System.Windows.Forms.PictureBox();
            this.obstacle2PictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FloorPictureBox
            // 
            this.FloorPictureBox.BackColor = System.Drawing.Color.Black;
            this.FloorPictureBox.Location = new System.Drawing.Point(-1, 437);
            this.FloorPictureBox.Name = "FloorPictureBox";
            this.FloorPictureBox.Size = new System.Drawing.Size(620, 38);
            this.FloorPictureBox.TabIndex = 0;
            this.FloorPictureBox.TabStop = false;
            // 
            // trexPictureBox
            // 
            this.trexPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("trexPictureBox.Image")));
            this.trexPictureBox.Location = new System.Drawing.Point(200, 375);
            this.trexPictureBox.Name = "trexPictureBox";
            this.trexPictureBox.Size = new System.Drawing.Size(56, 56);
            this.trexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trexPictureBox.TabIndex = 1;
            this.trexPictureBox.TabStop = false;
            // 
            // obstacle1PictureBox
            // 
            this.obstacle1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("obstacle1PictureBox.Image")));
            this.obstacle1PictureBox.Location = new System.Drawing.Point(317, 385);
            this.obstacle1PictureBox.Name = "obstacle1PictureBox";
            this.obstacle1PictureBox.Size = new System.Drawing.Size(23, 46);
            this.obstacle1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1PictureBox.TabIndex = 2;
            this.obstacle1PictureBox.TabStop = false;
            this.obstacle1PictureBox.Tag = "obstacle";
            // 
            // obstacle2PictureBox
            // 
            this.obstacle2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("obstacle2PictureBox.Image")));
            this.obstacle2PictureBox.Location = new System.Drawing.Point(473, 398);
            this.obstacle2PictureBox.Name = "obstacle2PictureBox";
            this.obstacle2PictureBox.Size = new System.Drawing.Size(32, 33);
            this.obstacle2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2PictureBox.TabIndex = 3;
            this.obstacle2PictureBox.TabStop = false;
            this.obstacle2PictureBox.Tag = "obstacle";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Location = new System.Drawing.Point(133, 27);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(47, 13);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // TRexMainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.obstacle2PictureBox);
            this.Controls.Add(this.obstacle1PictureBox);
            this.Controls.Add(this.trexPictureBox);
            this.Controls.Add(this.FloorPictureBox);
            this.Name = "TRexMainClass";
            this.Text = "TRex Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FloorPictureBox;
        private System.Windows.Forms.PictureBox trexPictureBox;
        private System.Windows.Forms.PictureBox obstacle1PictureBox;
        private System.Windows.Forms.PictureBox obstacle2PictureBox;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

