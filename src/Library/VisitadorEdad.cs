using System;
using System.Collections.Generic;

namespace Library
{
    public class VisitadorEdad : Visitador
    {
        public void Operaciones(Operaciones operaciones)
        {
            operaciones.Accept(this);
        }
        public void VisitPersona(Persona persona)
        {
            int val = persona.EdadTotal();
            Console.WriteLine("La suma total de edades es de : " + val + " años");
        }

        public void VisitNode(Node node)
        {
            int val = node.EdadTotal();
            Console.WriteLine("La suma total de edades es de : " + val +" años");
        }
    }
}