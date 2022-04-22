using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHerencia
{
    public class Alumno : Persona
    {
        public string Carne { get; set; }
        public List<int> Notas { get; set; }
    }
}