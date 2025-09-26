using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Registro_automotor.Models
{
    internal class Persona
    {
        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {              
                if (value <= 1000000) //si es menor a 1M lanza una exception
                {
                    throw new RangoDniIncorrectoException();
                }
                dni= value;
            }
        }

        public string Nombre { get; private set; }

        public Persona(int dni, string nombre)
        {
            this.Nombre = nombre;
            this.Dni = dni; 
        }
    }
}
