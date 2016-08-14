using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clan_System.Tables;

namespace Clan_System
{
    internal class Database
    {
        private readonly Clans _clanTable;
        private readonly Players _playerTable;
        private readonly ClanPlayers _clanPlayerTable;

        internal Clans ClanTable
        {
            get
            {
                return _clanTable;
            }
        }

        internal Players PlayerTable
        {
            get
            {
                return _playerTable;
            }
        }

        internal ClanPlayers ClanPlayerTable
        {
            get
            {
                return _clanPlayerTable;
            }
        }

        public Database()
        {
            _clanTable = new Clans();
            _playerTable = new Players();
            _clanPlayerTable = new ClanPlayers();
        }

        public void CreatePlayer(string name)
        {
            if (PlayerTable.Content.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("Player with that name already exists.");
            }
            else
            {
                PlayerTable.Content.Add(new Player(Players.GetNewId(), name));
            }
        }

        public void CreateClan(string name, string flag)
        {
            if (ClanTable.Content.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("Clan with that name already exists.");
            }
            else
            {
                ClanTable.Content.Add(new Clan(Clans.GetNewId(), flag, name));
            }
        }

        public void AddPlayerToClan(Player player, Clan clan, string role)
        {
            if (ClanPlayerTable.Content.Any(x => x.PlayerId == player.Id))
            {
                throw new InvalidOperationException("Player with that name already is a member of a clan.");
            }
            else
            {
                ClanPlayerTable.Content.Add(new ClanPlayer(clan.Id, player.Id, role));
            }
        }

        public Clan CheckPlayerClan(Player player)
        {
            var clanPlayerInfo = ClanPlayerTable.Content.FirstOrDefault(x => x.PlayerId == player.Id);

            return clanPlayerInfo == null ? null : ClanTable.Content.First(x => x.Id == clanPlayerInfo.ClanId);
        }
    }
}
