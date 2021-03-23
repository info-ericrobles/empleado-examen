using System;


namespace Matriz9
{
    class Matriz9
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Cargar();
            empleado.CalcularSumaSueldos();
            empleado.ImprimirTotalPagado();
            empleado.EmpleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}