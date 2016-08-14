using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System
{
    public class Player
    {
        private readonly int _id;
        private readonly string _name;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Player(int _id, string _name)
        {
            this._id = _id;
            this._name = _name;
        }
    }
}
