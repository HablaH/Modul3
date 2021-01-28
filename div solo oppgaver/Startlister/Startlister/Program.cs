using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Startlister
{
    class Program
    {
        public List<Club> Clubs;
        public List<Registration> RegistrationList;
        

        static void Main(string[] args)
        {
            
            var RegistrationList = new List<Registration>();

            ReadList()








        }
        

        public void CreateClubs()
        {
            foreach (var person in RegistrationList)
            {
                if (Clubs.Count == 0) Clubs.Add(new Club(person.Club));
                if (!Clubs.Exists(club => club?.Name == person.Club)) Clubs.Add(new Club(person.Club));
            }

            foreach (var club in Clubs)
            {
                club.Members = RegistrationList.Where(p => p.Club == club.Name).ToList();
            }
        }

        public void ReadList()
        {
            var allText = File.ReadAllLines("startlisterRaw.csv");

            foreach (string line in allText)
            {
                string[] words = line.Split(',');
                RegistrationList.Add(new Registration(words[0], words[1], words[2], words[3], words[4], words[5]));
            }
            RegistrationList.RemoveRange(0, 6);
        }

        public string ClubStats()
        {
            foreach (var VARIABLE in Clubs)
            {
                
            }
        }
    }
}
