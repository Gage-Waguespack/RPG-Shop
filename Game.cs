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
