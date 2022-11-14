using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : Operaciones
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

        public void Accept(VisitadorEdad visitador)
        {
            visitador.VisitNode(this);
        }

        public int MasGrande()
        {
            int mayor = 0;
            foreach (Node node in Children)
            {
                if (node.number > mayor)
                {
                    mayor = node.number;
                }
            }
            return mayor;
        }
        public void Accept(VisitadorHijoMasGrande visitador)
        {
            visitador.VisitNode(this);
        }
    }
}
