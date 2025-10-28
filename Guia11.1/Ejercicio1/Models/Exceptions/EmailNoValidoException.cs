using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exceptions
{
    public class EmailNoValidoException:ApplicationException
    {

        public EmailNoValidoException():base("EMAIL NO VÁLIDO") { }
        public EmailNoValidoException(string message):base(message) { }
        public EmailNoValidoException(string message, Exception innerException) : base(message, innerException) {}
    }
}
