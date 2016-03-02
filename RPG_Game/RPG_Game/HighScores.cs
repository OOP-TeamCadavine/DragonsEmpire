namespace RPG_Game
{
    using System.Collections.Generic;
    using System.IO;

    public class HighScores
    {
        private const string ScoresPath = "../../../Content/HighScores.txt";
        private StreamReader fileReader = new StreamReader(ScoresPath);
        // TODO: Fix writing and reading at the same time
        private StreamWriter fileWriter = new StreamWriter("../../../Content/Scores.txt");

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
            using (this.fileReader)
            {
                string line = this.fileReader.ReadLine();
                string[] input;

                while (line != null)
                {
                    input = line.Split(' ');
                        this.scores.Add(input[0], int.Parse(input[1]));

                    line = this.fileReader.ReadLine();
                }
            }
        }

        public void Save(string name, int score)
        {
            using (this.fileWriter)
            {
                if (scores.Count < 10 || score > lowestScore )
                {
                    fileWriter.Write("{0} {1}", name, score);
                }
            }
        }    
    }
}
