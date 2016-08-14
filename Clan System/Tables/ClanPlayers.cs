using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System.Tables
{
    class ClanPlayers
    {
        private readonly HashSet<ClanPlayer> _content;

        internal HashSet<ClanPlayer> Content
        {
            get
            {
                return _content;
            }
        }

        public ClanPlayers() { _content = new HashSet<ClanPlayer>(); }
    }
}
