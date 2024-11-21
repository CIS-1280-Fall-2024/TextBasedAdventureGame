using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    class HidingPlace : GameObject, IHidingPlace
    {
        public HidingPlace(string desription) : this(desription, null)
        {
        }

        public HidingPlace(string desription, GameObject hiddenObject)
        {
            Description = desription;
            this.hiddenObject = hiddenObject;
        }

        protected GameObject hiddenObject;

        public GameObject HiddenObject
        {
            get
            {
                return hiddenObject;
            }
            set
            {
                hiddenObject = value;
            }
        }

        public GameObject Search()
        {
            GameObject temp = hiddenObject;
            hiddenObject = null;
            return temp;
        }
    }
}
