using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System.Tables
{
    class Players
    {
        private static readonly int _id = 0;

        private readonly HashSet<Player> _content;

        internal HashSet<Player> Content
        {
            get
            {
                return _content;
            }
        }

        static Players() { _id = 0; }

        public Players() { _content = new HashSet<Player>(); }
    }
}
