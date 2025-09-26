using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Registro_automotor.Models
{
    internal class DepartamentoVehicular
    {

        public int CantidadRegistros
        {
            get { return registros.Count; }
        }

        int serie;

        private List<RegistroVehiculo> registros = new List<RegistroVehiculo>();

        public RegistroVehiculo RegistrarVehiculo (Persona propietario, string patente)
        {
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, propietario, serie++);
            registros.Add(nuevo); //agrego
            registros.Sort(); //ordeno
            return nuevo;
            
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < CantidadRegistros)
            {
                return registros[idx];

            }
            return null;
        }

        

        
    }
}
