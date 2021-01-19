using System;
using System.Collections.Generic;
using System.Text;

namespace Slektstre
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            StringBuilder str = new StringBuilder();
            str.Append(FirstName != null? FirstName + " ": string.Empty);
            str.Append(LastName != null ? LastName + " " : string.Empty);
            str.Append($"(Id={Id})");
            str.Append(BirthYear != 0 ? " Født: "+BirthYear.ToString() : string.Empty);
            str.Append(DeathYear != 0 ? " Død: "+DeathYear.ToString() : string.Empty);

            bool hasFather = Father != null;
            bool hasMother = Mother != null;

            str.Append(hasFather ? " Far: " : string.Empty);
            str.Append(hasFather ? Father.FirstName != null ? Father.FirstName + " " : string.Empty : string.Empty);
            str.Append(hasFather ? Father.Id != 0 ? $"(Id={Father.Id.ToString()})" : string.Empty : string.Empty);
            str.Append(hasMother ? " Mor: " : string.Empty);
            str.Append(hasMother ? Mother.FirstName != null ? Mother.FirstName + " " : string.Empty : string.Empty);
            str.Append(hasMother ? Mother.Id != 0 ? $"(Id={Mother.Id.ToString()})" : string.Empty : string.Empty);
            str.Append("\n");
            return str.ToString();
        }

        public string GetChildDescription()
        {
            StringBuilder str = new StringBuilder();
            str.Append(FirstName != null ? FirstName + " " : string.Empty);
            str.Append(LastName != null ? LastName + " " : string.Empty);
            str.Append($"(Id={Id})");
            str.Append(BirthYear != 0 ? " Født: " + BirthYear.ToString() : string.Empty);
            str.Append(DeathYear != 0 ? " Død: " + DeathYear.ToString() : string.Empty);
            return str.ToString();
        }
    }
}
