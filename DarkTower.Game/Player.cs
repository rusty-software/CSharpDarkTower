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

        public void SetFood(int food)
        {
            Food = food;
        }

        public void SetWarriors(int warriors)
        {
            Warriors = warriors;
        }

        public void AddScout()
        {
            HasScout = true;
        }

        public void AddHealer()
        {
            HasHealer = true;
        }

        public void AddBeast()
        {
            HasBeast = true;
        }

        public void AddSword()
        {
            HasSword = true;
        }

        public void AddPegasus()
        {
            HasPegasus = true;
        }

        public void AddBrassKey()
        {
            HasBrassKey = true;
        }

        public void AddSilverKey()
        {
            HasSilverKey = true;
        }

        public void AddGoldKey()
        {
            HasGoldKey = true;
        }
    }
}
