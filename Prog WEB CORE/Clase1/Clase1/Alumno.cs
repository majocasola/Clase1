using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Alumno
    {
        //los campos, propiedades, metodos y eventos de una clase se llaman miembros de clase
        // un objeto es la instancia de una clase
        // campos / atributos que son privados
        private int dni;
        private string apellido;
        private string nombre;
        // propiedad que encapsula el dni:
        // propiedades (encapsulamiento)
        // get set lectura y escritura
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        // encapsulo en apellido
        // autoimplementado
        public string Apellido {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public string Nombre { get; set; }
        public string Email { get; set; }   

        // metodos (en gral son publicos) Lo publico va en Mayus- lo privado en minisc
        public string TraerDatos()
        {
            // doc:(nro) (apellido) (nombre)
            string strDatos = $"DNI:{DNI} {Apellido}, {Nombre} Correo: {Email}";
            return strDatos;
        }

        
    }
}
