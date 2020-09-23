using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private Item[] _inventory;

        public Shop()
        {
            _inventory = new Item[3];
            _gold = 500;
        }

        public Shop(Item[] items)
        {
            _inventory = items;
            _gold = 500;
        }
        public bool Sell(Player player, int index, int playerindex)
        {
            if(player.Buy(_inventory[index], playerindex))
            {
                return true;
            }
            return false;
        }

    }
}
