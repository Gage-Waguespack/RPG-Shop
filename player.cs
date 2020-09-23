using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _gold = 100;
            _inventory = new Item[3];
        }

        public bool Buy(Item item, int index)
        {
            if (_gold >= item.cost)
            {
                _gold -= item.cost;
                _inventory[index] = item;
                return true;
            }
            return false;
        }

        public int GetGold()
        {
            return _gold;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }
    }
}
