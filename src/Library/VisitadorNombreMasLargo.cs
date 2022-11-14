using System;
using System.Collections.Generic;

namespace Library
{
    public class VisitadorNombreMasLargo
    {
        public void Operaciones(OperacionesUltimo operaciones)
        {
            operaciones.Accept(this);
        }
        public void VisitPersona(Persona persona)
        {
            string val = persona.MasLargo();
            Console.WriteLine("El nombre mas largo es: " + val);
        }
    }
}