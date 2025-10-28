using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exceptions
{
    public class DniNoValidoException:ApplicationException
    {
        public DniNoValidoException():base("DNI NO VÁLIDO") { }
        public DniNoValidoException(string message):base(message) { }
        public DniNoValidoException(string message, Exception innerException) : base(message, innerException){}
    }
}
