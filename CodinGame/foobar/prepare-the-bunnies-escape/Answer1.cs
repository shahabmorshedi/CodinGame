using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foobar
{
    class prepare_the_bunnies_escape
    {
        static int[,] FillTheMaze()
        {
            int[,] maze = new int[,] { { 0, 1, 1, 0 }, { 0, 0, 0, 1 }, { 1, 1, 0, 0 }, { 1, 1, 1, 0 } };
            //for (int i = 0; i < w; i++)
            //{
            //    for (int j = 0; j < w; j++)
            //        maze[i, j] = int.Parse(Console.ReadLine());
            //}
            return maze;
        }

        static void Main(string[] args)
        {
            var maze = FillTheMaze();
            MapTheGraph(maze);


            Console.ReadLine();
        }

        static void MapTheGraph(int[,] maze)
        {
            List<Node> nodes = new List<Node>();
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Node node = new Node(i, j);
                    if (i > 1)
                        node.LeftNode = new Node(i - 1, j);
                    if (i < 3)
                        node.LeftNode = new Node(i + 1, j);
                    if (j > 1)
                        node.LeftNode = new Node(i, j - 1);
                    if (j < 3)
                        node.LeftNode = new Node(i, j + 1);
                    nodes.Add(node);
                }
            }
        }

        static void FindPath(int x, int y)
        {
            
        }
    }

    class Node
    {
        public Node LeftNode
        {
            get;
            set;
        }
        public Node RightNode
        {
            get;
            set;
        }
        public Node UpNode
        {
            get;
            set;
        }
        public Node DownNode
        {
            get;
            set;
        }
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        public Node(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
