using System;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_App
{
    public partial class RPS_Game : Form
    {
        public RPS_Game()
        {
            InitializeComponent();
        }

        int tieTimes = 0;
        int winTimes = 0;
        int loseTimes = 0;

        int yourScore = 0;
        int enemyScore = 0;
        int ties = 0;
        
        int oneTie = 0;
        int oneLose = 0;
        int oneWin = 0;

        string enemyChoice = "";
        string userInput = "";

        int enemyRandomNumber;
        Random random = new Random();
        private void RPS_Game_Load(object sender, EventArgs e)
        {
            enemyRandomNumber = random.Next(1, 4);

            EnemyHandRock.Hide();
            EnemyHandPaper.Hide();
            EnemyHandScissors.Hide();

            PlayerHandRock.Hide();
            PlayerHandPaper.Hide();
            PlayerHandScissors.Hide();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            HideEnemyHand();
            UpdateEnemyHand();
            HidePlayerHand();
            BeginningTextBox.Hide();

            userInput = "Rock";
            CurrentInfo.Show();
            CurrentMove.Show();
            PlayerHandRock.Show();

            UpdateScoreField();
            ChangeFaceFeatures();
            ChangeFaceOnStreaks();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            HideEnemyHand();
            UpdateEnemyHand();
            HidePlayerHand();
            BeginningTextBox.Hide();

            userInput = "Paper";
            CurrentInfo.Show();
            CurrentMove.Show();
            PlayerHandPaper.Show();

            UpdateScoreField();
            ChangeFaceFeatures();
            ChangeFaceOnStreaks();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            HideEnemyHand();
            UpdateEnemyHand();
            HidePlayerHand();
            BeginningTextBox.Hide();

            userInput = "Scissors";
            CurrentInfo.Show();
            CurrentMove.Show();
            PlayerHandScissors.Show();

            UpdateScoreField();
            ChangeFaceFeatures();
            ChangeFaceOnStreaks();
        }
        void HideEnemyHand()
        {
            EnemyHand.Hide();
            EnemyHandRock.Hide();
            EnemyHandPaper.Hide();
            EnemyHandScissors.Hide();
        }
        void UpdateEnemyHand()
        {
            enemyRandomNumber = random.Next(1, 4);

            switch (enemyRandomNumber)
            {
                case 1:
                    enemyChoice = "Scissors";
                    HideEnemyHand();
                    EnemyHandScissors.Show();
                    break;
                case 2:
                    enemyChoice = "Paper";
                    HideEnemyHand();
                    EnemyHandPaper.Show();
                    break;
                case 3:
                    enemyChoice = "Rock";
                    HideEnemyHand();
                    EnemyHandRock.Show();
                    break;
            }
        }
        void HidePlayerHand()
        {
            PlayerHand.Hide();
            PlayerHandRock.Hide();
            PlayerHandPaper.Hide();
            PlayerHandScissors.Hide();
        }
        void UpdateScoreField()
        {
            if (userInput == enemyChoice)
            {
                ties++;
                CurrentInfo.Text = "It's a tie!!!";
                NumberOfTies.Text = $"Ties: {ties}";
            }
            else if ((userInput == "Rock" && enemyChoice == "Paper") || (userInput == "Paper" && enemyChoice == "Scissors")
                    || (userInput == "Scissors" && enemyChoice == "Rock"))
            {
                enemyScore++;
                CurrentInfo.Text = "You lost!";
            }
            else if ((userInput == "Rock" && enemyChoice == "Scissors") || (userInput == "Scissors" && enemyChoice == "Paper")
                    || (userInput == "Paper" && enemyChoice == "Rock"))
            {
                yourScore++;
                CurrentInfo.Text = "You won!";
            }
            ScoreField.Text = $"{yourScore}-{enemyScore}";
        }

        void ChangeFaceFeatures()
        {
            if (CurrentInfo.Text.Contains("tie"))
            {
                oneTie++;
                if (oneTie >= 1)
                {
                    Enemy.Hide();
                    EnemySad.Hide();
                    EnemySad2.Hide();
                    EnemyHappy.Hide();
                    EnemyHappy2.Hide();
                    EnemyConfused2.Hide();

                    EnemyConfused.Show();
                }
            }
            else if (CurrentInfo.Text.Contains("won"))
            {
                oneWin++;
                if (oneWin >= 1)
                {
                    Enemy.Hide();
                    EnemyConfused.Hide();
                    EnemyConfused2.Hide();
                    EnemyHappy.Hide();
                    EnemyHappy2.Hide();
                    EnemySad2.Hide();

                    EnemySad.Show();
                }
            }
            else if (CurrentInfo.Text.Contains("lost"))
            {
                oneLose++;
                if (oneLose >= 1)
                {
                    Enemy.Hide();
                    EnemySad.Hide();
                    EnemyConfused.Hide();
                    EnemyHappy.Show();
                }
            }
        }

        void ChangeFaceOnStreaks()
        {
            if (CurrentInfo.Text.Contains("tie"))
            {
                tieTimes++;
                if (tieTimes >= 3)
                {
                    EnemyConfused2.Show();

                    Enemy.Hide();
                    EnemyConfused.Hide();
                    EnemySad.Hide();
                    EnemySad2.Hide();
                    EnemyHappy2.Hide();
                    EnemyHappy.Hide();
                }
            }
            else
            {
                tieTimes = 0;
            }

            if (CurrentInfo.Text.Contains("won"))
            {
                winTimes++;
                if (winTimes >= 3)
                {
                    EnemySad2.Show();

                    EnemyHappy2.Hide();
                    EnemyConfused2.Hide();
                    Enemy.Hide();
                    EnemyConfused.Hide();
                    EnemySad.Hide();
                    EnemyHappy.Hide();
                }
            }
            else
            {
                winTimes = 0;
            }

            if (CurrentInfo.Text.Contains("lost"))
            {
                loseTimes++;
                if (loseTimes >= 3)
                {
                    EnemyHappy2.Show();

                    EnemySad2.Hide();
                    EnemyConfused2.Hide();
                    Enemy.Hide();
                    EnemyConfused.Hide();
                    EnemySad.Hide();
                    EnemyHappy.Hide();
                }
            }
            else
            {
                loseTimes = 0;
            }
        }
    }
}