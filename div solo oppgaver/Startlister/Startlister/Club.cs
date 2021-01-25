using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Startlister
{
    class Club
    {
        public string Name;
        public List<Registration> Members; 

        public Club(string name)
        {
            Name = name;
        }

        public void AddMembers(Registration member)
        {
            Members.Add(member);
        }

        public string GetMembers()
        {
            return Members.Aggregate(Name + ":\n", (seed, member) => seed + member.ToString());
        }
    }
}
