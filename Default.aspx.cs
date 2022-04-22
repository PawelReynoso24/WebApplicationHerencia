using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationHerencia
{
    public partial class _Default : Page
    {
        List<Persona> padres = new List<Persona>();
        List<Alumno> hijas = new List<Alumno>();
        List<Nieta> nietas = new List<Nieta>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona padre = new Persona();
            padre.propiedadpadre1 = 1;
            padre.Calculo();

            Alumno hija = new Alumno();
            hija.propiedadhija1 = 1;
            hija.propiedadpadre1 = 5;
            hija.Calculo();
            hija.funcion();

            Nieta nieta = new Nieta();
            nieta.propiedadnieta1 = 1;
            nieta.propiedadhija1 = 2;
            nieta.propiedadpadre1 = 100;
            nieta.Calculo();
            nieta.funcion();
        }
    }
}