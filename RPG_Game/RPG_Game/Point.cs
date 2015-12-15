namespace RPG_Game
{
    public struct Position
    {
        public Position(int xCoord, int yCoord)
            : this()
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        public int XCoord { get; set; }

        public int YCoord { get; set; }
    }
}
