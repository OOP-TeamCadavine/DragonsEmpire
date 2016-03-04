namespace RPG_Game.Common
{
    using System.Collections.Generic;
    using System.IO;

    public static class HighScores
    {
        private static string scoresPath = "../../../Content/HighScores.txt";

        private static Dictionary<string, Score> scores = new Dictionary<string, Score>();

        public static Dictionary<string, Score> GetScores()
        {
            return scores;
        }       

        public static void Load()
        {
            using (StreamReader fileReader = new StreamReader(scoresPath))
            {
                string line = fileReader.ReadLine();
                string[] input;

                while (!string.IsNullOrEmpty(line))
                {
                    input = line.Split(' ');
                    string name = input[0];
                    int enemyKilled = int.Parse(input[1]);
                    int experience = int.Parse(input[2]);


                    if (!scores.ContainsKey(name))
                    {
                        scores.Add(name, new Score(enemyKilled, experience));
                    }
                    else
                    {
                        if (scores[name].Experience < experience)
                        {
                            scores[name].Experience = experience;
                            scores[name].EnemyKilled = enemyKilled;
                        }
                    }    

                    line = fileReader.ReadLine();
                }
            }
        }

        public static void Save(string name, Score score)
        {
            using (StreamWriter fileWriter = new StreamWriter(scoresPath, true))
            {
                fileWriter.WriteLine("{0} {1} {2}", name, score.EnemyKilled, score.Experience);
            }
        }    
    }
}
