using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clan_System.Test;
using NUnit.Framework.Constraints;

namespace Clan_System.Test
{
    [TestFixture]
    public class Database_should
    {
        private Database db;

        [SetUp]
        public void SetUp()
        {
            db = new Database();
        }

        [Test]
        public void returnNull_whenCheckingUnexistingPlayer()
        {
            var result = db.CheckPlayerClan(new Player(0, "Anton"));
            Assert.IsNull(result);
        }

        [Test]
        public void addNewPlayer()
        {
            db.CreatePlayer("Anton");
            var player = db.PlayerTable.Content.FirstOrDefault(x => x.Name == "Anton");
            Assert.AreEqual(player.Name, "Anton");
        }

        [Test]
        public void throwException_whenNewPlayerIsNotUnique()
        {
            db.CreatePlayer("Anton");

            Assert.Throws<InvalidOperationException>(() => db.CreatePlayer("Anton"));
        }

        [Test]
        public void addPlayerToClan()
        {
            var clan = db.CreateClan("Yellow Clan", "Lemon");
            var player = db.CreatePlayer("Anton");

            db.AddPlayerToClan(player, clan, "King");

            Assert.True(db.ClanPlayerTable.Content.Count == 1);

            var clanPlayer1 = db.ClanPlayerTable.Content.First();
            var clanPlayer2 = new ClanPlayer(clan.Id, player.Id, "King");

            Assert.AreEqual(clanPlayer1, clanPlayer2);
        }
    }
}
