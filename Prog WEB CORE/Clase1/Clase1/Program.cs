using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // las clases en mayusc y singular

            // crear una instancia de Alumno (no es estatica)
            // nombre de clase y nombre del objeto para acceder a lo publico
            Alumno alu1 = new Alumno();
            alu1.DNI = 123456789;
            alu1.Apellido = "Perez";
            alu1.Nombre = "Juan";
            alu1.Email = "perez@gmail.com";

            // no se hace new de consola porque es estatica(todos sus miembros son estaticos)
            //Console.WriteLine($"DNI: {alu1.DNI}");
            Console.WriteLine($"Datos del alumno 1 : {alu1.TraerDatos()}");

            // crear otra instancia de la clase de Alumno
            Alumno alu2 = new Alumno();
            alu2.DNI = 33654123;
            alu2.Apellido = "Garcia";
            alu2.Nombre = "Jose";
            alu2.Email = "garcia@gmail.com";
            Console.WriteLine($"\nDatos del alumno 2 : {alu2.TraerDatos()}");


            Console.ReadKey();
        }
    }
}
