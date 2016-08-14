using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System
{
    internal class ClanPlayer
    {
        private readonly int _clanId;
        private readonly int _playerId;
        private readonly int _role;

        public int ClanId
        {
            get
            {
                return _clanId;
            }
        }

        public int PlayerId
        {
            get
            {
                return _playerId;
            }
        }

        public int Role
        {
            get
            {
                return _role;
            }
        }
    }
}
