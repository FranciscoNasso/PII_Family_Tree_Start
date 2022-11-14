using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona : Operaciones , OperacionesUltimo
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
        public void Accept(VisitadorEdad visitador)
        {
            visitador.VisitPersona(this);
        }

        public string MasGrande()
        {
            int mayor = 0;
            string nombremayor = "";
            foreach (Persona personas in Children)
            {
                if (personas.Edad > mayor)
                {
                    mayor = personas.Edad;
                    nombremayor = personas.Nombre;
                }
            }
            return nombremayor;
        }
        public void Accept(VisitadorHijoMasGrande visitador)
        {
            visitador.VisitPersona(this);
        }

        public string MasLargo()
        {
            int largo = Nombre.Length;
            string nombrelargo = Nombre;
            foreach (Persona personas in Children)
            {
                if (personas.Nombre.Length > largo)
                {
                    largo = personas.Nombre.Length;
                    nombrelargo = personas.Nombre;
                }
            }
            return nombrelargo;
        }
        public void Accept(VisitadorNombreMasLargo visitador)
        {
            visitador.VisitPersona(this);
        }
    }
}