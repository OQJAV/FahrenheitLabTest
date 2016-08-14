using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan_System.Tables
{
    internal class Clans
    {
        private static int _id;

        private readonly HashSet<Clan> _content;

        internal HashSet<Clan> Content
        {
            get
            {
                return _content;
            }
        }

        static Clans() { _id = 0; }

        public Clans() { _content = new HashSet<Clan>(); }

        public static int GetNewId()
        {
            return _id++;
        }
    }
}
