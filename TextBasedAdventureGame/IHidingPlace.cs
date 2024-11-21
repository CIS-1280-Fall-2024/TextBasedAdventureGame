using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    interface IHidingPlace
    {
        GameObject Search();

        GameObject HiddenObject { get; set; }
    }
}
