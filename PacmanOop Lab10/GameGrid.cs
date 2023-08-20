using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PacmanOop_Lab10
{
   public class GameGrid
    {

        GameCell[,] gameCells;
        int Rows;
        int Cols;
        string Filename;

        public int Rows1 { get => Rows; set => Rows = value; }
        public int Cols1 { get => Cols; set => Cols = value; }
        public string Filename1 { get => Filename; set => Filename = value; }
        internal GameCell[,] GameCells { get => gameCells; set => gameCells = value; }


        public GameGrid(string Filename,int Rows,int Cols)
        {
            this.Rows = Rows;
            this.Cols = Cols;
            this.Filename = Filename;
            GameCells= new GameCell[Rows,Cols];
        }

        public void LoadGrid(string Path)
        {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < record.Count(); x++)
                {
                    GameCells[row, x] = new GameCell(row, x);
                    GameCells[row, x].currentGameObject = new GameObject(GameObject.GetGameObjectType(record[x]),record[x]);
                }
                row++;
            }

            fp.Close();
        }


        public GameCell GetCell(int x,int y)
        {
            return GameCells[x, y];
        }
    }
}
