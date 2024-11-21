using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class Player
    {
        //Fields
        private int inventorySize;
        //Properties
        public MapLocation Location { get; set; }
        public List<IPortable> Inventory { get; set; }
        public int MaxInventory { get; set; }        

        //Constructors
        public Player(MapLocation location)
        {
            Location = location;
            Inventory = new List<IPortable>();
            Inventory.Add(new InventoryItem("pocket lint"));
            MaxInventory = 6;
        }

        //Methods

        public bool AddInventoryItem(IPortable item)
        {
            if(inventorySize+item.Size < MaxInventory)
            {
                Inventory.Add(item);
                inventorySize += item.Size;
                Calc();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void RemoveInventoryItem(IPortable item)
        {
            Inventory.Remove(item);
            Calc();
        }

        private void Calc()
        {
            inventorySize = 0;
            foreach(IPortable item in Inventory)
            {
                inventorySize+=item.Size;
            }
        }
    }
}
