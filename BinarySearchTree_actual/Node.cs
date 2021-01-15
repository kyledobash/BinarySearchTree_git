using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_actual
{
    public class Node
    {
        // member variables
        public int data;
        Node leftChild;
        Node rightChild;

        // constructor
        public Node()
        {
            rightChild = new Node();
            leftChild = new Node();
        }

        // member methods

    }
}
