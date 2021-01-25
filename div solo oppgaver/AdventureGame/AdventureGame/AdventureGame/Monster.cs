using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Monster
    {
        private int _health;
        private int _damage;
        private string _name;
        private Room _currentRoom;

        public Monster(string name, int health, Room currentRoom)
        {
            _name = name;
            _health = health;
            _damage = health / 10;
            _currentRoom = currentRoom;
        }

        public void AttackPlayer()
        {
            if (_currentRoom == Player.currentRoom)
            {
                Player.health = Player.health - _damage;
            }
        }

    }
}
