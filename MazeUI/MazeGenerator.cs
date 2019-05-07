using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeUI
{
    class MazeGenerator
    {
        public static Cell[][] generate(int size)
        {
            Random rnd = new Random();

            Cell[][] cells = new Cell[size][];
            for (int i = 0; i < size; i++)
                cells[i] = new Cell[size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    cells[i][j] = new Cell();
                    if (i == 0) cells[i][j].Walls[(int)Cell.Dir.Top] = true;
                    if (i == size - 1) cells[i][j].Walls[(int)Cell.Dir.Bottom] = true;

                    if (j == 0) cells[i][j].Walls[(int)Cell.Dir.Left] = true;
                    if (j == size - 1) cells[i][j].Walls[(int)Cell.Dir.Right] = true;
                }

            Tuple<int, int> startingPoing = new Tuple<int, int>(rnd.Next(0, size), rnd.Next(0, size));
            Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();
            path.Push(startingPoing);
            while(path.Count > 0)
            {
                LinkedList<Cell.Dir> dirs = cells[path.Peek().Item1][path.Peek().Item2].getWithoutWalls();
                Cell.Dir nextMove = dirs.ElementAt(rnd.Next(0, dirs.Count()));

            }

            return cells;

        }
    }
}
