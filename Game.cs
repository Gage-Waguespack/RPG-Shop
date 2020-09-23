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
        private Shop _shop;
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
            _gameOver = false;
            _player = new Player();
            InitializeItems();
            _shopInventory = new Item[] { _arrow, _shield, _gem };
            _shop = new Shop(_shopInventory);
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
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost);
                _shopInventory[i] = inventory[i];
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("So, you seem to be an adventurer! \nWell I may have just what you need, no matter what class you are!");
            PrintInventory(_shopInventory);

            //Get player input
            char input = Console.ReadKey().KeyChar;

            //Set itemIndex to be the index the player selected
            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            //if the player can't afford the item, print a message to let them know
            if (_player.GetGold() < _shopInventory[itemIndex].cost)
            {
                Console.WriteLine("You can't afford this.");
                return;
            }

            // Ask the player a slot to replace their own inventory
            Console.WriteLine("Choose a slot to replace!");
            PrintInventory(_shopInventory);

            input = Console.ReadKey().KeyChar;

            int playerIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            _shop.Sell(_player, itemIndex, playerIndex);

        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
