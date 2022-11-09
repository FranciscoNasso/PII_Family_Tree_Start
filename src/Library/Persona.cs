using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona : Operaciones
    {
        private string nombre;
        private int edad;
        private int number;

        private List<Persona> children = new List<Persona>();

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Persona> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void AddChildren(Persona n)
        {
            this.children.Add(n);
        }
        
        public int EdadTotal()
        {
            int total = Edad;
            foreach (Persona personas in Children)
            {
                total += personas.Edad;
            }
            return total;
        }
        public void Accept(Visitador1 visitador)
        {
            visitador.VisitPersona(this);
        }
    }
}