namespace DarkTower.Game
{
    public class Player
    {
        public int Warriors { get; private set; }
        public int Gold { get; private set; }
        public int Food { get; private set; }

        public bool HasScout { get; private set; }
        public bool HasHealer { get; private set; }
        public bool HasBeast { get; private set; }

        public bool HasPegasus { get; private set; }
        public bool HasSword { get; private set; }

        public bool HasBrassKey { get; private set; }
        public bool HasSilverKey { get; private set; }
        public bool HasGoldKey { get; private set; }

        public Player()
        {
            Warriors = 10;
            Gold = 30;
            Food = 25;

            HasScout = false;
            HasHealer = false;
            HasBeast = false;

            HasPegasus = false;
            HasSword = false;

            HasBrassKey = false;
            HasSilverKey = false;
            HasGoldKey = false;
        }
    }
}
