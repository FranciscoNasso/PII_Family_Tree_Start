namespace Library
{
    public interface Operaciones
    {
        void Accept (VisitadorEdad visitador);
        void Accept (VisitadorHijoMasGrande visitador);
    }
}