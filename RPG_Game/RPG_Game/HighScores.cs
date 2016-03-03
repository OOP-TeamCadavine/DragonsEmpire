namespace RPG_Game
{
    using System.Collections.Generic;
    using System.IO;

    public static class HighScores
    {
        private static string scoresPath = "../../../Content/HighScores.txt";

        private static Dictionary<string, int> scores = new Dictionary<string, int>();

        public static Dictionary<string, int> GetScores()
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
                    int experience = int.Parse(input[1]);


                    if (!scores.ContainsKey(name))
                    {
                        scores.Add(name, experience);
                    }
                    else
                    {
                        if (scores[name] < experience)
                        {
                            scores[name] = experience;
                        }
                    }    

                    line = fileReader.ReadLine();
                }
            }
        }

        public static void Save(string name, int score)
        {
            using (StreamWriter fileWriter = new StreamWriter(scoresPath, true))
            {
                fileWriter.WriteLine("{0} {1}", name, score);
            }
        }    
    }
}
