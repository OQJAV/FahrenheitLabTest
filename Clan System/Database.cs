﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clan_System.Tables;
using NUnit.Framework;

namespace Clan_System
{
    public class Database
    {
        private readonly Clans _clanTable;
        private readonly Players _playerTable;
        private readonly ClanPlayers _clanPlayerTable;

        public Clans ClanTable
        {
            get
            {
                return _clanTable;
            }
        }

        public Players PlayerTable
        {
            get
            {
                return _playerTable;
            }
        }

        public ClanPlayers ClanPlayerTable
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

        public Player CreatePlayer(string name)
        {
            if (PlayerTable.Content.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("Player with that name already exists.");
            }
            else
            {
                var player = new Player(Players.GetNewId(), name);
                PlayerTable.Content.Add(player);
                return player;
            }
        }

        public Clan CreateClan(string name, string flag)
        {
            if (ClanTable.Content.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("Clan with that name already exists.");
            }
            else
            {
                var clan = new Clan(Clans.GetNewId(), flag, name);
                ClanTable.Content.Add(clan);
                return clan;
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
