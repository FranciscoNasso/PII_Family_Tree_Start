using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // Parte 2  

            Persona p1 = new Persona("Jamal", 15);
            Persona p2 = new Persona("Ozuna", 22);
            Persona p3 = new Persona("Messi", 34);
            Persona p4 = new Persona("Ankara", 25);
            Persona p5 = new Persona("LeaFit", 78);
            Persona p6 = new Persona("Ibai", 36);
            Persona p7 = new Persona("Doge", 13);
            Persona p8 = new Persona("Maradios", 99);

            p1.AddChildren(p2);
            p1.AddChildren(p3);

            p2.AddChildren(p4);
            p2.AddChildren(p5);

            p3.AddChildren(p6);
            p3.AddChildren(p7);

            p6.AddChildren(p8);

            // Parte 3

            VisitadorEdad v1 = new VisitadorEdad();
            v1.Operaciones(p8);
            v1.Operaciones(n2);

            // Parte 4

            VisitadorHijoMasGrande v2 = new VisitadorHijoMasGrande();
            v2.Operaciones(p5);
            v2.Operaciones(n1);

            VisitadorNombreMasLargo v3 = new VisitadorNombreMasLargo();
            v3.Operaciones(p5);
        }
    }
}
