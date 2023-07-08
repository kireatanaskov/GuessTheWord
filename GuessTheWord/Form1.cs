using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class Form1 : Form
    {
        GameForm gameForm;
        LeaderboardForm leaderboardForm;
        HowToPlayForm howToPlayForm;
        public List<Player> Players { get; set; }
        public Form1()
        {
            InitializeComponent();
            Players = new List<Player>();
        }

        public void ReadData()
        {
            Players.Clear();
            //string currentDirectory = Application.StartupPath;
            string fileName = "Players.csv";
            string filePath = Path.Combine(Application.StartupPath, fileName);
            string[] lines = File.ReadAllLines(filePath);

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');

                    string playerName = values[0];
                    double playerScore = Double.Parse(values[1]);

                    Players.Add(new Player(playerName, playerScore));
                }
            }
        }

        public void OpenRegisterForm(double score)
        {
            var registerForm = new RegisterForm(this, score);
            registerForm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameForm = new GameForm(this);
            gameForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            leaderboardForm = new LeaderboardForm(this);
            leaderboardForm.ShowDialog();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            howToPlayForm = new HowToPlayForm();
            howToPlayForm.ShowDialog();
        }
    }
}
