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
            //creates a new item array with three items with deafault values
            _inventory = new Item[3];
        }

        public bool Buy(Item item, int inventoryindex)
        {
            if (_gold >= item.cost)
            {
                // pays for the item then places it in the inventory array
                _gold -= item.cost;
                _inventory[inventoryindex] = item;
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
