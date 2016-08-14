using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System
{
    internal class Clan
    {
        private readonly int _id;
        private readonly string _flag;
        private readonly string _name;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Flag
        {
            get
            {
                return _flag;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
