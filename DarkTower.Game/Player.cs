using System;

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

        private int LimitToRange(int v, int min, int max)
        {
            if (v < min) { return min; }
            if (v > max) { return max; }
            return v;
        }

        public void SetGold(int gold)
        {
            var maxGold = Warriors * 6 + (HasBeast ? 50 : 0);
            maxGold = (maxGold > 99) ? 99 : maxGold;
            Gold = LimitToRange(gold, 0, maxGold);
        }

        public void AddBeast()
        {
            HasBeast = true;
        }

        public void SetWarriors(int warriors)
        {
            Warriors = warriors;
        }
    }
}
