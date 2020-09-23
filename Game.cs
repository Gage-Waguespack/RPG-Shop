using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    //Create a shop that will allow the player to buy items from the shops inventory, and add them to their own inventory.
    //The player should be able to spend gold to buy an item.If the player does not have enough to buy the item, they should
    //be prevented from buying the item. You can show the player a message to let them know.After buying an item, the player should be
    //able to replace one of the items in their own inventory with the new item.

    public struct Item
    {
        public string name;
        public int cost;
    }

    class Game
    {

        private Item _arrow;
        private Item _shield;
        private Item _gem;
        private bool _gameOver = false;
        private Player _player;
        private Shop shop;
        private Item[] _shopInventory;
        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome!!! \nWanna take a look at my wares??");
        }

        private void InitializeItems()
        {
            _arrow.name = "Arrow";
            _arrow.cost = 20;
            _shield.name = "Shield";
            _shield.cost = 30;
            _gem.name = "Healing Gem";
            _gem.cost = 50;
        }

        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < _shopInventory.Length; i++)
            {
                _shopInventory[i] = inventory[i];
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("So, you seem to be an adventurer! \nWell I may have just what you need, no matter what class you are!");
            char input = ' ';
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                _player.Buy(_arrow, 0);
                Shop.Sell(_player, 0, 0);
            }
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
