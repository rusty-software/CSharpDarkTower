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
    }
}
