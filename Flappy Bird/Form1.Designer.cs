namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pipeT = new PictureBox();
            flappyBird = new PictureBox();
            pipeB = new PictureBox();
            ground = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeT
            // 
            pipeT.Image = Properties.Resources.pipedown;
            pipeT.Location = new Point(496, 0);
            pipeT.Name = "pipeT";
            pipeT.Size = new Size(125, 254);
            pipeT.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeT.TabIndex = 0;
            pipeT.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(33, 223);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(73, 65);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeB
            // 
            pipeB.Image = Properties.Resources.pipe;
            pipeB.Location = new Point(281, 428);
            pipeB.Name = "pipeB";
            pipeB.Size = new Size(124, 199);
            pipeB.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeB.TabIndex = 2;
            pipeB.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-32, 618);
            ground.Name = "ground";
            ground.Size = new Size(748, 112);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gamTimerevent;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.DarkKhaki;
            scoreText.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(84, 651);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(0, 48);
            scoreText.TabIndex = 4;
            scoreText.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(660, 708);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeB);
            Controls.Add(pipeT);
            Controls.Add(flappyBird);
            Name = "Form1";
            Text = "   ";
            Load += Form1_Load;
            KeyDown += gamekeyisDowm;
            KeyUp += gamekeyisUp;
            ((System.ComponentModel.ISupportInitialize)pipeT).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeB).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeT;
        private PictureBox flappyBird;
        private PictureBox pipeB;
        private PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
    }
}
