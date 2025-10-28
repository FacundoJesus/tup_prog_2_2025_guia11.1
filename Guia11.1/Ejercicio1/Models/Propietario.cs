using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ejercicio1.Models.Exceptions;

namespace Ejercicio1.Models
{
    public class Propietario
    {
        private int dni;
        public int DNI {
            get
            {
                return dni;
            }
            set
            {
                if(value < 1000000)
                {
                    throw new DniNoValidoException();
                }
                dni = value;
            }
        }

        public string ApellidoNombre { get; set; }

        private string email;
        public string Email { 
            get {
                return email;
            }
            set {
                Regex regex = new Regex(@"^\s+@{1}\s+\.com\.\s{2}");
                Match match = regex.Match(value);
                if(!match.Success) {
                    throw new EmailNoValidoException();
                }
                email = value;
            }
        }

        public Propietario(int dni, string nombre, string email)
        {
            this.DNI = dni;
            this.ApellidoNombre = nombre;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"{this.ApellidoNombre} ({this.DNI})";
        }
    }
}
