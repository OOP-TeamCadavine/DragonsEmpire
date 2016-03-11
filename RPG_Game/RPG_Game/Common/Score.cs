namespace RPG_Game.Common
{
    using System;

    public class Score : IComparable<Score>
    {
        private int experience;

        private int enemyKilled;

        public Score(int enemyKilled, int experience)
        {
            this.EnemyKilled = enemyKilled;
            this.Experience = experience;
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Experience cannot be negative.");
                }

                this.experience = value;
            }
        }

        public int EnemyKilled
        {
            get
            {
                return this.enemyKilled;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enemy killed cannot be negative.");
                }

                this.enemyKilled = value;
            }
        }

        public int CompareTo(Score other)
        {
            int result = this.Experience.CompareTo(other.Experience);

            if (result == 1)
            {
                return this.EnemyKilled.CompareTo(other.EnemyKilled);
            }

            return result;
        }
    }
}
