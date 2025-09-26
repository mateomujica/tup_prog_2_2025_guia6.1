using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Registro_automotor.Models
{
    internal class RangoDniIncorrectoException : ApplicationException
    {
       
            public RangoDniIncorrectoException()
                : base("Formato DNI no valido, ingrese DNI mayor a 1.000.000")
            {
            }

            public RangoDniIncorrectoException(string? message)
                : base(message)
            {
            }

            public RangoDniIncorrectoException(string? message, Exception? innerException)
                : base(message, innerException)
            {
            }

            protected RangoDniIncorrectoException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            
        }

    }
}
