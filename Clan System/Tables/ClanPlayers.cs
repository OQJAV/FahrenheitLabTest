using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System.Tables
{
    public class ClanPlayers
    {
        private readonly HashSet<ClanPlayer> _content;

        public HashSet<ClanPlayer> Content
        {
            get
            {
                return _content;
            }
        }

        public ClanPlayers() { _content = new HashSet<ClanPlayer>(); }
    }
}
