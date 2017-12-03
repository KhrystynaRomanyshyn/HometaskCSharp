using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class MyTree
    {
        public Node Root { get; set; }

        public void AddNode(int a)
        {
            if (Root == null)
            {
                Root = new Node();
                Root.Value = a;
                return;
            }

            AddInternal(a, Root);    
        }

        void AddInternal(int value, Node currentNode)
        {
            if (currentNode.Value < value)
            {
                if (currentNode.RightNode == null)
                {
                    currentNode.RightNode = new Node();
                    currentNode.RightNode.Value = value;
                    return;
                }

                AddInternal(value, currentNode.RightNode);
                return;
            }

            if (currentNode.Value > value)
            {
                if (currentNode.LeftNode == null)
                {
                    currentNode.LeftNode = new Node();
                    currentNode.LeftNode.Value = value;
                    return;
                }

                AddInternal(value, currentNode.LeftNode);
                return;
            }
        }
    }
}
