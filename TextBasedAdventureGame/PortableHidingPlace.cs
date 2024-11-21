using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    class PortableHidingPlace : HidingPlace, IPortable
    {
        public PortableHidingPlace(string desription, int size) : this(desription, size, null)
        {
        }

        public PortableHidingPlace(string desription,int size, GameObject hiddenObject):base(desription,hiddenObject)
        {
            Size = size;
        }

        public int Size { get; set; }
    }
}
