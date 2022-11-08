using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private int number;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public int EdadTotal()
        {
            int total = Number;
            foreach (Node nodes in Children)
            {
                total += nodes.Number;
            }
            return total;
        
        }

        public void Accept(Visitador1 visitor)
        {
            visitor.VisitNode(this);
        }
    }
}
