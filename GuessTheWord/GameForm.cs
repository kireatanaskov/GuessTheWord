using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class GameForm : Form
    {
        readonly List<string> words = new List<string>() { "ELEPHANT", "BONSAI", "EUPHORIA", "PARADOX", "ACROBAT", "CHAIR", "MOON", "RAIN" };
        
        private Dictionary<string, List<string>> hints = new Dictionary<string, List<string>>();
        
        private Random random = new Random();

        private double Score = 10;

        private List<string> usedWords = new List<string>();

        private Form1 form1;

        private SoundPlayer soundPlayer;
        public HiddenWord hiddenWord { get; set; }
        private int TimeLeft { get; set; } = 60;
        private int HintsLeft { get; set; } = 3;
        private int Mistakes = 0;
        public GameForm(Form1 form)
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(Properties.Resources.clock);
            hiddenWord = new HiddenWord(words[random.Next(words.Count)]);
            lblWord.Text = hiddenWord.GetHiddenWord();
            usedWords.Add(hiddenWord.Word);
            timer1.Start();
            lblTimer.Text = "01:00";
            lblHint.Text = "";
            lblHintsLeft.Text = $"Hints left: {HintsLeft}";
            this.form1 = form;
            toolStripStatusLabel1.Text = $"Mistakes: {Mistakes}";

            foreach (string word in words)
            {
                hints[word] = new List<string>();
                if (word == "ELEPHANT")
                {
                    hints[word].Add("A thickset, usually extremely large, nearly hairless, herbivorous mammal");
                    hints[word].Add("It is the largest living land animal.");
                    hints[word].Add("a very large plant-eating mammal with a prehensile trunk, long curved ivory tusks, and large ears, native to Africa and southern Asia.");
                } else if (word == "BONSAI")
                {
                    hints[word].Add("A potted plant (such as a tree) dwarfed (as by pruning) and trained to an artistic shapethe art of growing such a plant ");
                    hints[word].Add("The art of growing miniature trees in pots through careful cultivation and pruning");
                    hints[word].Add("A tree kept small enough to be container-grown while otherwise fostered to have a mature appearance");
                }
                else if (word == "EUPHORIA")
                {
                    hints[word].Add("A feeling of intense happiness, excitement, or joy.");
                    hints[word].Add("A feeling of well-being or elation");
                    hints[word].Add("A feeling of happiness, confidence, or well-being sometimes exaggerated in pathological states as mania.");
                }
                else if (word == "PARADOX")
                {
                    hints[word].Add("A statement that is seemingly contradictory or opposed to common sense and yet is perhaps true.");
                    hints[word].Add("A self-contradictory statement that at first seems true");
                    hints[word].Add("An argument that apparently derives self-contradictory conclusions by valid deduction from acceptable premises");
                }
                else if (word == "ACROBAT")
                {
                    hints[word].Add("A person who performs spectacular and agile moves, often in a circus or gymnastics.");
                    hints[word].Add("An entertainer who performs spectacular gymnastic feats");
                    hints[word].Add("A person who entertains people by doing difficult and skilful physical things, such as walking along a high wire");
                }
                else if (word == "CHAIR")
                {
                    hints[word].Add("A piece of furniture designed for one person to sit on, typically having a back and four legs.");
                    hints[word].Add("It can be \"electric\"");
                    hints[word].Add("Comes in various shapes, sizes, and styles, catering to different needs and preferences.");
                }
                else if (word == "MOON")
                {
                    hints[word].Add("The natural satellite of the Earth");
                    hints[word].Add("Reflects light from the sun and appears in various phases.");
                    hints[word].Add("Revolves about the earth from west to east in about 29¹/₂ days");
                }
                else if (word == "RAIN")
                {
                    hints[word].Add("Water that falls from the clouds in droplets, creating wet weather conditions.");
                    hints[word].Add("A crucial component of the Earth's water cycle.");
                    hints[word].Add("Plays a vital role in sustaining life and supporting ecosystems.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length != 1)
            {
                errorProvider1.SetError(textBox1, "Внесете само една буква!");
            } else
            {
                if (char.IsLetter(textBox1.Text[0]))
                {
                    char letter = Char.ToUpper(textBox1.Text[0]);
                    if (hiddenWord.AllLetters.Contains(letter))
                    {
                        hiddenWord.GuessLetter(textBox1.Text[0]);
                        lblWord.Text = hiddenWord.GetHiddenWord();
                    } else
                    {
                        Mistakes++;
                    }
                }
                if (hiddenWord.AllLetters.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to submit your score?", "Submit", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        this.Score = (TimeLeft * 1.5) + (HintsLeft * 3) - Mistakes;
                        form1.OpenRegisterForm(Score);
                    }
                    this.Close();
                }
                UpdateStatusLabel();
                textBox1.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up!", "Game over", MessageBoxButtons.OK);
                soundPlayer.Stop();
                this.Close();
            } 
            else if (hiddenWord.AllLetters.Count == 0) 
            {
                timer1.Stop();
                soundPlayer.Stop();
                this.Close();
            } 
            else
            {
                TimeLeft--;
                pbVreme.Value = TimeLeft;
                lblTimer.Text = $"{TimeLeft / 60:D2}:{TimeLeft % 60:D2}";
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            soundPlayer.Stop();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            List<string> HintsForTheWord = hints[hiddenWord.Word];
            int randomIndex = random.Next(HintsForTheWord.Count);
            if (HintsForTheWord.Count > 0)
            {
                string randomHint = HintsForTheWord[randomIndex];
                HintsForTheWord.Remove(randomHint);
                lblHint.Text = randomHint;
                HintsLeft--;
            } else
            {
                lblHint.Text = "No more hints left :(";
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lblHint.Text = "";
            UpdateHintsLabel();
        }

        private void UpdateHintsLabel()
        {
            lblHintsLeft.Text = $"Hints left: {HintsLeft}";
        }

        private void UpdateStatusLabel()
        {
            toolStripStatusLabel1.Text = $"Mistakes: {Mistakes}";
        }
    }
}
