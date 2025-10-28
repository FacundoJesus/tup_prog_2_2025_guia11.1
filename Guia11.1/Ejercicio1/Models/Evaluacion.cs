using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public Evaluacion(string nombre, string descripcion) {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public abstract TipoAprobacion Evaluar();

        public override string ToString()
        {
            return $"{this.Nombre} - {this.Descripcion} - {Evaluar()}";
        }
    }
}
