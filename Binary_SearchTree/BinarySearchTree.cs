using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_SearchTree
{
    public class BinarySearchTree
    {
        
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}