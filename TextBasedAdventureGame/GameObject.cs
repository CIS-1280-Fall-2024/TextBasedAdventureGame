// GameObject
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 2 Apr 2017
// Represents an object in the game.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    /// <summary>
    /// Represents any object in the scene or in inventory.
    /// </summary>
    public class GameObject
    {
        /// <summary>
        /// Description of the object to be shown to user.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// One parameter constructor.
        /// </summary>
        /// <param name="description">Description of the object to be shown to user.</param>
        public GameObject(string description)
        {
            Description = description;
        }

        /// <summary>
        /// Parameterless constructor defaults to "Misterious object" description.
        /// </summary>
        public GameObject()
        {
            Description = "Misterious object.";
        }
        
        public override string ToString()
        {
            return Description;
        }
    }
}
