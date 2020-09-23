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
            //sets out inventory arrat to be the array of items that was passed in!!!
            _inventory = items;
            _gold = 500;
        }
        public bool Sell(Player player, int itemIndex, int playerIndex)
        {
            //find the item to buy in the inventory array
            Item itemToBuy = _inventory[itemIndex];
            //check to see if the player purchased the item successfully
            if(player.Buy(itemToBuy, playerIndex))
            {
                //Increase shops gold by item cost to complete the transaction
                _gold += itemToBuy.cost;
                return true;
            }
            return false;
        }

    }
}
