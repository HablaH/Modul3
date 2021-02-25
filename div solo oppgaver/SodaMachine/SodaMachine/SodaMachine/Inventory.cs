using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SodaMachine
{
    class Inventory
    {
        public List<Soda> Sodas;

        public Inventory(int FantaAmount, int CokeAmount, int SpriteAmount, int UrgeAmount)
        {
            Sodas = new List<Soda>();
            AddSodas("Fanta",20, FantaAmount);
            AddSodas("Coke",20, CokeAmount);
            AddSodas("Sprite",20, SpriteAmount);
            AddSodas("Urge",20, UrgeAmount);
        }

        private void AddSodas(string name, int price, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Sodas.Add(new Soda(name, price));
            }
        }

        public Soda GetSoda(string name)
        {
            var choice = Sodas.Find(s => s.Name.Equals(name));
            Sodas.Remove(choice);
            return choice;
        }
    }
}
