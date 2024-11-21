using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class InventoryItem:GameObject,IPortable
    {
        public int Size { get { return 1; } }

        //Constructors
        public InventoryItem(string description)
        {
            Description = description;
        }
    }
}
