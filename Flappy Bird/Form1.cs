namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        // Variables to control game speed, gravity, score, and pause state
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        bool isPaused = false;

        // Declare scoreLabel and gameOverTimer
        private Label scoreLabel;
        private System.Windows.Forms.Timer? gameOverTimer; // Declare gameOverTimer as nullable

        public Form1()
        {
            InitializeComponent();

            // Initialize scoreLabel and gameOverTimer
            scoreLabel = new Label();
            InitializeScoreLabel();
            gameOverTimer = null; // Initialize gameOverTimer as null
            InitializeGameOverTimer();
        }

        // Method to initialize scoreLabel
        private void InitializeScoreLabel()
        {
            scoreLabel.Text = "Score: 0";
            scoreLabel.Font = new Font("Arial", 12);
            scoreLabel.Location = new Point(10, 10);
            Controls.Add(scoreLabel);
        }

        // Method to initialize gameOverTimer
        private void InitializeGameOverTimer()
        {
            gameOverTimer = new System.Windows.Forms.Timer();
            gameOverTimer.Interval = 1000; // Set the interval in milliseconds (e.g., 1000 ms = 1 second)
            gameOverTimer.Tick += (sender, e) => { gameOverTimer!.Stop(); ShowGameOverMessage(); }; // Show message when the timer ticks
        }

        // Method to show game over message
        private void ShowGameOverMessage()
        {
            var result = MessageBox.Show("Game Over!! Your Score: " + score, "Game Over", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close(); // Close the form when OK is pressed
            }
        }

        // Method to handle click event for scoreLabel
        private void label1_Click(object sender, EventArgs e)
        {
            // Unused
        }

        // Method to handle game timer tick event
        private void gamTimerevent(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                flappyBird.Top += gravity;
                pipeB.Left -= pipeSpeed;
                pipeT.Left -= pipeSpeed;
                if (pipeB.Left < -150)
                {
                    pipeB.Left = 800;
                    score++;
                }
                if (pipeT.Left < -180)
                {
                    pipeT.Left = 950;
                    score++;
                }
                if (flappyBird.Bounds.IntersectsWith(pipeB.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeT.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
                {
                    endGame();
                }
                if (score > 5)
                {
                    pipeSpeed = 15;
                    ApplyPowerUp();
                }
                scoreLabel.Text = "Score: " + score;
            }
        }

        // Method to handle key down event
        private void gamekeyisDowm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            else if (e.KeyCode == Keys.P)
            {
                TogglePause();
            }
        }

        // Method to handle key up event
        private void gamekeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        // Method to toggle game pause state
        private void TogglePause()
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                gameTimer.Stop();
                scoreLabel.Text = "Paused";
            }
            else
            {
                gameTimer.Start();
                scoreLabel.Text = "Score: " + score;
            }
        }

        // Method to apply power-up
        private void ApplyPowerUp()
        {
            // Example: Double the gravity as a power-up
            gravity *= 2;
        }

        // Method to end the game
        private void endGame()
        {
            gameTimer.Stop();
            gameOverTimer!.Start(); // Start the timer to show the message
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Unused
        }
    }
}
