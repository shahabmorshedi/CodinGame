using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.DwarfsStandingOnTheShouldersOfGiants
{
    class DwarfsStandingOnTheShouldersOfGiants
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // the number of relationships of influence
            Node root = null;
            List<Node> trees = new List<Node>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]); // a relationship of influence between two people (x influences y)
                int y = int.Parse(inputs[1]);

                if (root == null)
                {
                    root = new Node(x);
                    trees.Add(root);
                    Node influenced = new Node(y);
                    root.Childs.Add(influenced);
                }
                else
                {
                    checkedNode.Clear();
                    Node influencer = FindNode(trees, x); //trees.Where(t => Find(x, t) != null).FirstOrDefault();
                    
                    if (influencer == null)
                    {
                        influencer = new Node(x);
                        trees.Add(influencer);
                    }

                    checkedNode.Clear();
                    Node influenced = FindNode(trees, y);

                    if (influenced == null)
                        influenced = new Node(y);

                    influencer.Childs.Add(influenced);
                }
            }

            Console.WriteLine(MeasureDepth(trees));
            Console.ReadLine();
        }

        private static Node FindNode(List<Node> trees, int x)
        {
            foreach (var t in trees)
            {
                var node = Find(x, t);
                if (node != null)
                    return node;
            }
            return null;
        }

        private static int MeasureDepth(List<Node> roots)
        {
            int depth = 0;
            foreach (Node root in roots)
            {
                int d = Depth(root);
                if (d > depth)
                    root.Depth = depth = d;
            }

            return depth;
        }

        private static int Depth(Node node)
        {
            if (node.Depth > 0)
            {
                return node.Depth;
            }
            else if (node.Childs.Count > 0)
            {
                int deeper = 0;
                foreach (var n in node.Childs)
                {
                    int d = Depth(n);
                    if (d > deeper)
                        node.Depth = deeper = d;
                }
                return deeper + 1;
            }

            return node.Depth = 1;
        }

        private static List<Node> checkedNode = new List<Node>();
        private static Node Find(int id, Node root)
        {
            if (id == root.ID)
                return root;

            for (int i = 0; i < root.Childs.Count; i++)
            {
                if (!checkedNode.Contains(root.Childs[i]))
                {
                    checkedNode.Add(root.Childs[i]);
                    var n  = Find(id, root.Childs[i]);
                    if (n == null)
                        continue;
                    else
                        return n;
                }
            }

            return null;
        }

    }

    class Node
    {
        public int ID
        {
            private set;
            get;
        }

        public int Depth
        {
            get;
            set;
        }

        private List<Node> _childs;
        public List<Node> Childs
        {
            get
            {
                if (_childs == null)
                    _childs = new List<Node>();
                return _childs;
            }
            set
            {
                _childs = value;
            }
        }

        public Node(int id)
        {
            this.ID = id;
        }
    }
}