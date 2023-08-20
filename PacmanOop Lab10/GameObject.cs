using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOop_Lab10
{
    public class GameObject
    {
        public char displayCharacter;
        public GameCell currentCell;

        protected char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        protected GameCell CurrentCell { get => currentCell; set => currentCell = value; }

        public GameObjectType type;
        private GameObjectType none;

        public GameObject(char displayCharacter,GameCell CurrentCell)
        {
            this.displayCharacter = displayCharacter;
            this.CurrentCell = currentCell;
        }

        public GameObject(GameObjectType none, char DisplayCharacter)
        {
            this.none = none;
            this.DisplayCharacter = displayCharacter;
        }

        public static GameObjectType GetGameObjectType(char DisplayCharacter)
        {
            if (DisplayCharacter=='%' || DisplayCharacter=='|' || DisplayCharacter=='#')
            {
                return GameObjectType.Wall;
            }
            else if (DisplayCharacter=='P')
            {
                return GameObjectType.Player;
            }
            else if (DisplayCharacter=='G')
            {
                return GameObjectType.Enemy;
            }
            else if (DisplayCharacter=='.')
            {
                return GameObjectType.Reward;
            }
            else
            {
                return GameObjectType.None;
            }

            
        }
    }
}
