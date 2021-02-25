using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.VisualBasic;

namespace SodaMachine
{
    class SodaMachine
    {
        private int cashRegister;
        public Inventory Inventory;

        public SodaMachine()
        {
            Inventory = new Inventory(5, 15, 20, 10);
        }

        public void Insert()
        {
            Console.WriteLine("Insert amount here(any number):");
            var amount = Console.ReadLine();
            bool validAmount = int.TryParse(amount, out int a);
            if (validAmount)
            {
                cashRegister += a;
                Console.WriteLine(ShowAmount());
            }
            else
            {
                Console.WriteLine("input needs to be a number");
                Insert();
            }
        }

        public string ShowAmount()
        {
            return cashRegister.ToString();
        }

        public string Select()
        {
            bool canSelect = int.TryParse(Console.ReadLine(), out int i)&&(i<=4 && i >= 1);

            if (canSelect)
            {
                return i switch
                {
                    1 => Inventory.GetSoda("Fanta").Name,
                    2 => Inventory.GetSoda("Coke").Name,
                    3 => Inventory.GetSoda("Sprite").Name,
                    4 => Inventory.GetSoda("Urge").Name,
                    _ => "please select 1:Fanta, 2: Coke, 3: Sprite or 4: Urge"
                };
            }

            return "please select 1:Fanta, 2: Coke, 3: Sprite or 4: Urge";
        }

        public void HandleCommand(string text)
        {
            switch (text.ToLower())
            {
                case "insert":
                {
                    Insert();
                    break;
                }
                case "select":
                {
                    Console.WriteLine(Select());
                    break;
                }
                case "return":
                {
                    Insert();
                    break;
                }

                default:
                {
                    Console.WriteLine("command not recognized, try: 'insert', 'select' or 'return'");
                    HandleCommand(Console.ReadLine());
                    break;
                }
            }

            ;
        }
    }
}
