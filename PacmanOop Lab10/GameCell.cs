using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanOop_Lab10
{
    public class GameCell
    {
        public int x;
        public int y;
        public GameObject currentGameObject;
        public GameGrid gameGrid;
        

        public GameCell(int x,int y,GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = grid;
            
        }

        public GameCell(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public GameCell()
        {
            // Initialize the currentGameObject property with a default value
            currentGameObject = new GameObject(GameObjectType.None, ' ');
        }

        public GameCell NextCell(GameDirection Direction)
        {
            if (Direction == GameDirection.Up)
            {
                return gameGrid.GetCell(x - 1, y);
            }
            else if (Direction == GameDirection.Down)
            {
                return gameGrid.GetCell(x + 1, y);
            }
            else if (Direction == GameDirection.Right)
            {
                return gameGrid.GetCell(x, y + 1);
            }
            else
            {
                return gameGrid.GetCell(x, y-1);
            }
           

        }





    }
}
