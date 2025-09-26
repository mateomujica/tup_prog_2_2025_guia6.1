using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1._Registro_automotor.Models
{
    internal class RegistroVehiculo : IComparable
    {
        public string Patente { get; private set; }
        public int Serie { get; private set; }

        public Persona Propietario { get; private set; }
        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            this.Patente = patente;
            this.Serie = serie;
            this.Propietario = propietario;

            Regex regex = new Regex(@"^[A-Z]{3}\s*[0-9]{3}$", RegexOptions.IgnoreCase); //Verifico que la patente tenga 3 letras y 3 numeros
            Match matchPatente = regex.Match(patente);
            if (matchPatente.Success == false)
            {
                throw new FormatoPatenteNoValidaException(); //Si no lanza exception
            }
        }

        public int CompareTo(object? obj)
        {
            RegistroVehiculo existe = obj as RegistroVehiculo;

            if (existe != null)
            {
                this.Patente.CompareTo(existe.Patente); //comparo por patente 
            }
            return -1;

        }

        public override string ToString()
        {
            return $"Patente: {Patente} - Propietario: {Propietario.Nombre} (DNI: {Propietario.Dni})";
        }
    }
}
