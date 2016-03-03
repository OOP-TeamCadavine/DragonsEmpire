namespace RPG_Game
{
    using System.Collections.Generic;
    using System.IO;

    public class HighScores
    {
        private const string ScoresPath = "../../../Content/HighScores.txt";

        private Dictionary<string, int> scores = new Dictionary<string, int>();
        private int lowestScore;

        public Dictionary<string, int> Scores
        {
            get
            {
                return this.scores;
            }
        }

        public void Load()
        {
            using (StreamReader fileReader = new StreamReader("../../../Content/HighScores.txt"))
            {
                string line = fileReader.ReadLine();
                string[] input;

                while (line != null && string.IsNullOrEmpty(line))
                {
                    input = line.Split(' ');
                        this.scores.Add(input[0], int.Parse(input[1]));

                    line = fileReader.ReadLine();
                }
            }
        }

        public void Save(string name, int score)
        {
            using (StreamWriter fileWriter = new StreamWriter("../../../Content/HighScores.txt", true))
            {
                if (scores.Count < 10 || score > lowestScore )
                {
                    fileWriter.WriteLine("{0} {1}", name, score);
                }
            }
        }    
    }
}
