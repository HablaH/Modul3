using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    { 
        static void Main(string[] args)
        {
            Human harald = new Human();
            Animal mads = new Animal();

            Console.WriteLine("Human");
            harald.Shit("food");
            Console.WriteLine(harald._arm);
            Console.WriteLine(harald._leg);
            Console.WriteLine("Animal");
            mads.Shit("");
            Console.WriteLine(mads._arm);
            Console.WriteLine(mads._leg);
        }
    }

    class Body
    {
        public int _weight;
        public int _arm;
        public int _leg;
        protected string privates;
        //constructor empty
        public Body()
        {
            _weight = 80;

        }

        public Body(int inputWeight)
        {
            _weight = inputWeight;

        }

        public virtual void Shit(string food)
        {
            Console.WriteLine("Bodily function");
        }

    }


    class Head : Body
    {
        public string _brain;

        public Head()
        {
            _brain = "thoughts";
        }
    }
    
    class Human : Head
    {
        public string sentience;

        public Human()
        {
            sentience = "yes";
            _leg = 2;
            _arm = 2;
            Console.WriteLine(privates);
        }

        public override void Shit(string food)
        {
            base.Shit(food);
            Console.WriteLine("human..");
        }
    }
    
    class Animal : Head
    {
        public string sentience;

        public Animal()
        {
            sentience = "no";
            _leg = 4;
            _arm = 0;
        }

        public override void Shit(string food)
        {
            Console.WriteLine("ikuhagiuawerhg");
        }
    }
}
