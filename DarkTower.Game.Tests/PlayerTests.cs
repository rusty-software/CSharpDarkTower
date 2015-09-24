using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkTower.Game.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_Initializes_WithExpectedInventory()
        {
            var player = new Player();

            Assert.AreEqual(10, player.Warriors);
            Assert.AreEqual(30, player.Gold);
            Assert.AreEqual(25, player.Food);
            Assert.IsFalse(player.HasScout);
            Assert.IsFalse(player.HasHealer);
            Assert.IsFalse(player.HasBeast);
            Assert.IsFalse(player.HasSword);
            Assert.IsFalse(player.HasPegasus);
            Assert.IsFalse(player.HasBrassKey);
            Assert.IsFalse(player.HasSilverKey);
            Assert.IsFalse(player.HasGoldKey);
        }

        [TestMethod]
        public void SetGold_Works()
        {
            var player = new Player();
            player.SetGold(27);
            Assert.AreEqual(27, player.Gold);
        }

        [TestMethod]
        public void SetWarriors_Works()
        {
            var player = new Player();
            player.SetWarriors(27);
            Assert.AreEqual(27, player.Warriors);
        }

        [TestMethod]
        public void SetFood_Works()
        {
            var player = new Player();
            player.SetFood(27);
            Assert.AreEqual(27, player.Food);
        }

        [TestMethod]
        public void AddScout_Works()
        {
            var player = new Player();
            player.AddScout();
            Assert.IsTrue(player.HasScout);
        }

        [TestMethod]
        public void AddHealer_Works()
        {
            var player = new Player();
            player.AddHealer();
            Assert.IsTrue(player.HasHealer);
        }

        [TestMethod]
        public void AddBeast_Works()
        {
            var player = new Player();
            player.AddBeast();
            Assert.IsTrue(player.HasBeast);
        }

        [TestMethod]
        public void AddSword_Works()
        {
            var player = new Player();
            player.AddSword();
            Assert.IsTrue(player.HasSword);
        }

        [TestMethod]
        public void AddPegasus_Works()
        {
            var player = new Player();
            player.AddPegasus();
            Assert.IsTrue(player.HasPegasus);
        }

        [TestMethod]
        public void AddBrassKey_Works()
        {
            var player = new Player();
            player.AddBrassKey();
            Assert.IsTrue(player.HasBrassKey);
        }

        [TestMethod]
        public void AddSilverKey_Works()
        {
            var player = new Player();
            player.AddSilverKey();
            Assert.IsTrue(player.HasSilverKey);
        }

        [TestMethod]
        public void AddGoldKey_Works()
        {
            var player = new Player();
            player.AddGoldKey();
            Assert.IsTrue(player.HasGoldKey);
        }


        [TestMethod]
        public void Gold_IsLimitedByWarriorCount()
        {
            var player = new Player();
            player.SetWarriors(2);
            player.SetGold(1000);
            Assert.AreEqual(player.Warriors * 6, player.Gold);
        }

        [TestMethod]
        public void Gold_LimitIncreasedByBeast()
        {
            var player = new Player();
            player.SetWarriors(2);
            player.AddBeast();
            player.SetGold(1000);
            Assert.AreEqual(player.Warriors * 6 + 50, player.Gold);
        }

        [TestMethod]
        public void Gold_CannotExceed99()
        {
            var player = new Player();
            player.SetWarriors(99);
            player.SetGold(1000);
            Assert.AreEqual(99, player.Gold);
        }

        [TestMethod]
        public void Gold_CannotFallBelowZero()
        {
            var player = new Player();
            player.SetGold(-27);
            Assert.AreEqual(0, player.Gold);
        }
    }
}
