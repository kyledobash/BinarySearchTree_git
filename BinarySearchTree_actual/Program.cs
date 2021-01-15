using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_actual
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree test = new BinarySearchTree(140);

            test.Add(test.rootNode, 300);
            test.Add(test.rootNode, 50);
            test.Add(test.rootNode, 20);
            test.Add(test.rootNode, 200);
            test.Add(test.rootNode, 10);
            Console.ReadLine();
        }
    }
}
