using System;
using System.IO;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class RegisterForm : Form
    {
        Form1 form1;
        private double Score { get; set; }
        public RegisterForm(Form1 form, double score)
        {
            InitializeComponent();
            this.Score = score;
            tbScore.Text = Score.ToString();
            this.form1 = form;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text.ToString()) || String.IsNullOrWhiteSpace(tbUsername.Text.ToString())) 
            {
                errorProviderRegister.SetError(tbUsername, "Please enter an username");
            } else
            {
                string playerName = tbUsername.Text.ToString().Trim();
                double playerScore = Double.Parse(tbScore.Text);

                string fileName = "Players.csv";
                string filePath = Path.Combine(Application.StartupPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, true)) 
                {
                    writer.WriteLine($"{playerName};{playerScore}");
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
