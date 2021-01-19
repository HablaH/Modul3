using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Slektstre
{
    public class FamilyApp
    {
        public Person[] _people;


        public FamilyApp(params Person[] people)
        {

            _people = people;
        }

        public string HandleCommand(string command)
        {
            var commands = command.Split(' ');

            switch (commands[0])
            {
                case "hjelp":
                    return HelpText;
                case "liste":
                    return ListAllPeople();
                case "vis" when commands[1] != null:
                    return GetPerson(commands[1])+GetChildren(commands[1]);
                default: return "noe er feil, skriv 'hjelp' for hjelpetekst";
            }
        }

        public bool HasChildren(int id)
        {
            return _people.Any(p => p.Father != null && p.Father.Id == id|| p.Mother != null && p.Mother.Id == id);
        }

        public string GetChildren(string Id)
        {
            StringBuilder str = new StringBuilder();
            bool IdIsInt = int.TryParse(Id, out var id);
            if (!HasChildren(id)) return str.ToString();
                str.Append("  Barn:\n");
            
                foreach (var person in _people)
                {
                    bool hasFather = person.Father != null;
                    str.Append(hasFather && person.Father.Id == id ? "    " + person.GetChildDescription() + "\n" : string.Empty);
                    bool hasMother = person.Mother != null;
                    str.Append(hasMother && person.Mother.Id == id ? "    " + person.GetChildDescription() + "\n" : string.Empty);
            }
            return str.ToString();
        }

        public string GetPerson(string Id)
        {
            StringBuilder str = new StringBuilder();
            bool IdIsInt = int.TryParse(Id, out var id);

            if (!IdIsInt) str.Append($"Ingen person med denne Id: {id}"); 
                
            foreach (var person in _people)
            {
                if (person.Id == id) str.Append(person.GetDescription());
            }

            return str.ToString();
        }

        public string ListAllPeople()
        {
            var str = new StringBuilder();
            foreach (var person in _people)
            {
                str.Append(person.GetDescription() + "\r\n");
            }

            return str.ToString();
        }

        public string WelcomeMessage = "Velkommen til familie appen!";
        public string HelpText = "For å finne data sjekk først om det ligger i registeret ved å skrive \"liste\"";
        public string CommandPrompt =
            "\n" +
            "----------------------------------------------------------------------------------------- \n" +
            "hjelp   => viser en hjelpetekst som forklarer alle kommandoene \n" +
            "liste   => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert. \n" +
            "vis<id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem) \n" +
            "----------------------------------------------------------------------------------------- \n" +
            "\n\n";
    }
}
