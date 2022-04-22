using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHerencia
{
    public class Hija : Padre
    {
        public string Carne { get; set; }
        public List<int> Notas { get; set; }
    }
}