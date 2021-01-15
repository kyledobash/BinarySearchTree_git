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
                parent.rightChild = new Node(newNodeData);
            }
            else if (newNodeData < parent.data)
            {
                parent.leftChild = new Node(newNodeData);
            }
        }
        public Node Search(int searchData)
        {

        }
    }
}
