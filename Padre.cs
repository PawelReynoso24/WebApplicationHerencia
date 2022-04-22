using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHerencia
{
    public class Padre
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime Nacimiento { get; set; }

        public int Calculo()
        {
            //podría ir cualquier cálculo de edad
            return (DateTime.Now.Year - Nacimiento.Year);
        }
    }
}