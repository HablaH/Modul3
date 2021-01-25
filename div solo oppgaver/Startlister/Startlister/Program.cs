using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace Startlister
{
    class Program
    {
        static void Main(string[] args)
        {
            var allText = File.ReadAllLines("startlisterRaw.csv");
            var registrationList = new List<Registration>();

            foreach (string line in allText)
            {
                string[] words = line.Split(',');
                registrationList.Add(new Registration(words[0], words[1], words[2], words[3], words[4], words[5]));
            }
            registrationList.RemoveRange(0,6);

            var clubs = new List<Club>();

            foreach (var person in registrationList)
            {
                if (clubs.Count == 0) clubs.Add(new Club(person.Club));
                if (!clubs.Exists(club => club?.Name == person.Club)) clubs.Add(new Club(person.Club));
            }

            foreach (var club in clubs)
            {
                club.Members = registrationList.Where(p => p.Club == club.Name).ToList();
            }

            foreach (var club in clubs)
            {
                Console.WriteLine(club.GetMembers());
            }
        }
    }
}
