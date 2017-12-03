using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main()
        {
            MyTree tree = new MyTree();
            tree.AddNode(8);
            tree.AddNode(7);
            tree.AddNode(10);
            tree.AddNode(5);
            tree.AddNode(6);
            tree.AddNode(3);
        }
    }
}
