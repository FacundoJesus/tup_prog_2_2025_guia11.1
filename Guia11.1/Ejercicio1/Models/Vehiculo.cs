using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Vehiculo:IComparable
    {
        public string Patente { get; set; }
        public int DNIPropietario { get; set; }
        public string NombrePropietario { get; set; }

        public Vehiculo(string patente, int dniPropietario, string nombrePropietario)
        {
            this.Patente = patente;
            this.DNIPropietario = dniPropietario;
            this.NombrePropietario = nombrePropietario;
        }

        public int CompareTo(object obj)
        {
            Vehiculo nuevoVehiculo = obj as Vehiculo;
            if(nuevoVehiculo != null)
            {
                return this.Patente.CompareTo(nuevoVehiculo.Patente);
            }
            return -1;
        }
    }
}
