namespace GuessTheWord
{
    public class Player
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Player(string name, double score)
        {
            Name = name;
            Score = score;
        }
    }
}