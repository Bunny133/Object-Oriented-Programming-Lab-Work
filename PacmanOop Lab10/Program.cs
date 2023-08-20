using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Threading;

namespace PacmanOop_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {


            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            grid.LoadGrid("maze.txt");
            GameCell start = new GameCell(12, 22, grid);

            printMaze(grid);

            // GamePacManPlayer pacman = new GamePacManPlayer('p', start);
            //pacman.currentCell = start;  // Assign the GameCell object to the currentCell property of pacman

            //printGameObject(pacman);


            //bool gameRunning = true;
            //while (gameRunning)
            //{
            //    Thread.Sleep(90);
            //    if (Keyboard.IsKeyPressed(Key.UpArrow))
            //    {
            //        moveGameObject(pacman, GameDirection.Up);
            //    }

            //    if (Keyboard.IsKeyPressed(Key.DownArrow))
            //    {
            //        moveGameObject(pacman, GameDirection.Down);
            //    }

            //    if (Keyboard.IsKeyPressed(Key.RightArrow))
            //    {
            //        moveGameObject(pacman, GameDirection.Right);
            //    }

            //    if (Keyboard.IsKeyPressed(Key.LeftArrow))
            //    {
            //        moveGameObject(pacman, GameDirection.Left);
            //    }
            //}
            Console.ReadKey();
        }
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
            {
                gameCell.currentGameObject = newGameObject;
                Console.SetCursorPosition(gameCell.y, gameCell.x);
                Console.Write(newGameObject.displayCharacter);

            }
            static void printGameObject(GameObject gameObject)
            {
                Console.SetCursorPosition(gameObject.currentCell.y, gameObject.currentCell.x);
                Console.Write(gameObject.displayCharacter);

            }

            static void moveGameObject(GameObject gameObject, GameDirection direction)
            {
                GameCell nextCell = gameObject.currentCell.NextCell(direction);
                if (nextCell != null)
                {
                    GameObject newGO = new GameObject(GameObjectType.None, ' ');
                    GameCell currentCell = gameObject.currentCell;
                    clearGameCellContent(currentCell, newGO);
                    gameObject.currentCell = nextCell;
                    printGameObject(gameObject);
                }
            }

            static void printMaze(GameGrid grid)
            {
                for (int x = 0; x < grid.Rows1; x++)
                {
                    //int abc = 0;
                    for (int y = 0; y < grid.Cols1; y++)
                    {
                        GameCell cell = grid.GetCell(x, y);
                        printCell(cell);
                    }

                }
            }

        static void printCell(GameCell cell)
        {
            if (cell != null)
            {


                Console.SetCursorPosition(cell.y, cell.x);
                Console.Write(cell.currentGameObject.displayCharacter);
            }
        }
        }
    }
