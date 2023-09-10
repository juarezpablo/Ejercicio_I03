using Entidades;
namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("silva","1345","pepito");
            Estudiante estudiante2 = new Estudiante("ruiz", "13456", "jose");
            Estudiante estudiante3 = new Estudiante("tere", "134578", "jorge");
            estudiante1.SetNotaPrimerParcial(6);
            estudiante1.SetNotaSegundoParcial(7);
            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(9);
            estudiante3.SetNotaPrimerParcial(2);
            estudiante3.SetNotaSegundoParcial(4);
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}