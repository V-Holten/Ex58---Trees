using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex58___Trees
{
    public class MyBST<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        private Node root;

        private void InsertHelper(T item, Node root)
        {
            if (root.Data.CompareTo(item) < 0)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = new Node();
                    root.RightChild.Data = item;
                }
                else
                {
                    InsertHelper(item, root.RightChild);
                }
            }

            if (root.Data.CompareTo(item) > 0)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = new Node();
                    root.LeftChild.Data = item;
                }
                else
                {
                    InsertHelper(item, root.LeftChild);
                }
            }
        }

        public void Insert(T item)
        {
            if (root == null)
                root = new Node { Data = item };
            else
                InsertHelper(item, root);
        }

        private void InOrderHelper(Node root, List<T> list)
        {
            if (root != null)
            {
                InOrderHelper(root.LeftChild, list);
                list.Add(root.Data);
                InOrderHelper(root.RightChild, list);
            }
        }
        public List<T> InOrder()
        {
            List<T> list = new List<T>();

            InOrderHelper(root, list);

            return list;
        }

    }
}
