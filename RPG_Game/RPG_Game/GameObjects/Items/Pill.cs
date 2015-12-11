using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Items
{
    public class Pill : Item, IHeal
    {
        private const int DefaultHealthRestore = 10;

        public Pill(Point position)
            : base(position)
        {
            this.HealthRestore = DefaultHealthRestore;
        }

        public int HealthRestore { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Health restore ({1})", this.GetType().Name, this.HealthRestore);
        }
    }
}

