using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class EvaluacionSimple:Evaluacion
    {
        public bool HaVerificado {  get; set; }

        public EvaluacionSimple(string nombre, string descripcion,bool  haverificado):base(nombre,descripcion)
        {
            this.HaVerificado = haverificado;
        }

        public override TipoAprobacion Evaluar()
        {
            if (HaVerificado) return TipoAprobacion.Aprobado;
            else return TipoAprobacion.NoAprobacion;
        }

    }
}
