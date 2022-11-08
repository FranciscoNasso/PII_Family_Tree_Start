using System;
using System.Collections.Generic;

namespace Library
{
    public interface Visitador
    {
        void Operaciones(Operaciones operaciones){}
        void VisitPersona(Persona persona){}
        void VisitNode(Node node){}
    }
}