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
        private readonly string _role;

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

        public string Role
        {
            get
            {
                return _role;
            }
        }

        public ClanPlayer(int _clanId, int _playerId, string _role)
        {
            this._clanId = _clanId;
            this._playerId = _playerId;
            this._role = _role;
        }

    }
}
