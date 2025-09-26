using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Registro_automotor.Models
{
    internal class FormatoPatenteNoValidaException : ApplicationException
    {


        public FormatoPatenteNoValidaExceptionn() 
            : base("Formato patente no válido")
        {
        }
        
        public FormatoPatenteNoValidaException(string? message) : base(message)
        {
        }

        public FormatoPatenteNoValidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FormatoPatenteNoValidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
