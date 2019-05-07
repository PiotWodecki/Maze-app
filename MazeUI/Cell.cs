using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeUI
{
    class Cell
    {
        public enum Dir
        {
            Top, Right, Left, Bottom
        }

        private bool[] walls;
        
        public bool[] Walls
        {
            get { return walls; }
        }

        public Cell()
        {
            walls = new bool[4];
        }

        public void makeWall(Cell.Dir dir)
        {
            walls[(int)dir] = true;
        }

        public bool isWall(Cell.Dir dir)
        {
            return walls[(int)dir];
        }

        public LinkedList<Cell.Dir> getWithoutWalls()
        {
            LinkedList<Cell.Dir> ret = new LinkedList<Cell.Dir>();
            if (!isWall(Dir.Top)) ret.AddLast(Dir.Top);
            if (!isWall(Dir.Left)) ret.AddLast(Dir.Left);
            if (!isWall(Dir.Bottom)) ret.AddLast(Dir.Bottom);
            if (!isWall(Dir.Right)) ret.AddLast(Dir.Right);
            return ret;
        }

    }
}
