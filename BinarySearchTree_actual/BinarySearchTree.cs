using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_actual
{
    public class BinarySearchTree
    {
        // member variables
        public Node rootNode;
        
        // constructor
        public BinarySearchTree(int data)
        {
            rootNode = new Node(data);
        }
        // member methods
        public void Add(Node parent, int newNodeData)
        {
            if (newNodeData > parent.data)
            {
                if (parent.rightChild == null)
                {
                    parent.rightChild = new Node(newNodeData);
                }
                else
                {
                    this.Add(parent.rightChild, newNodeData);
                }
            }
            else if (newNodeData < parent.data)
            {
                if (parent.leftChild == null)
                {
                    parent.leftChild = new Node(newNodeData);
                }
                else
                {
                    this.Add(parent.leftChild, newNodeData);
                }
            }
        }

        public Node Search(Node parent, int searchData)
        {
            if (parent.data == searchData)
            {
                return parent;
            }
            else
            {
                if (searchData >  parent.data)
                {
                    if (parent.rightChild == null)
                    {
                        return null;
                    }
                    else
                    {
                        return Search(parent.rightChild, searchData);
                    }
                }
                else
                {
                    if (parent.leftChild == null)
                    {
                        return null;
                    }
                    else
                    {
                        return Search(parent.leftChild, searchData);                        
                    }
                }
            }
        }
    }
}
