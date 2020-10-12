using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Codewars_
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
    class SortBinaryTreeByLevels
    {
        public static void TreeByLevels(Node node, ref List<int> resList)
        {
            var queue = new Queue<Node>();
            resList.Add(node.Value);
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                if (queue.Peek().Left != null)
                {
                    resList.Add(queue.Peek().Left.Value);
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    resList.Add(queue.Peek().Right.Value);
                    queue.Enqueue(queue.Peek().Right);
                }
                queue.Dequeue();
            }
        }
        public static List<int> TreeByLevels(Node node)
        {
            if (node == null)
                return new List<int>();

            List<int> resList = new List<int>();

            TreeByLevels(node, ref resList);

            return resList;
        }



    }
}
