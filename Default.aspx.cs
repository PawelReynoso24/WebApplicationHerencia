using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationHerencia
{
    public partial class _Default : Page
    {
        //List<Persona> personas = new List<Persona>();
        static List<Alumno> alumnos = new List<Alumno>();
        static List<int> NotasTemp = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Persona padre = new Persona();
            //padre.propiedadpadre1 = 1;
            //padre.Calculo();

            //Alumno hija = new Alumno();
            //hija.propiedadhija1;
            //hija.propiedadpadre1;
            //hija.Calculo();
            //hija.funcion();

            //Nieta nieta = new Nieta();
            //nieta.propiedadnieta1 = 1;
            //nieta.propiedadhija1 = 2;
            //nieta.propiedadpadre1 = 100;
            //nieta.Calculo();
            //nieta.funcion();
        }

        private void Guardar()
        {
            //Suponiendo que la List llamada lista ya contiene datos

            //Se serializa (convierte) la lista en formato Json y se guarda en una variable de tipo string
            string json = JsonConvert.SerializeObject(alumnos);

            //El nombre del archivo
            string archivo = Server.MapPath("Datos.json");

            //Se escribe la variable que contiene el json al archivo en un solo paso
            //con WriteAllText se escribe todo de un solo
            System.IO.File.WriteAllText(archivo, json);
        }

        private void Lectura()
        {
            //Se crea una lista con la misma estructura que tienen los datos en el archivo
            List<Alumno> lista = new List<Alumno>();

            //El nombre del archivo a utilizar
            string archivo = Server.MapPath("Datos.json");

            //Se abre el archivo
            StreamReader jsonStream = File.OpenText(archivo);

            //Se Lee todo el contenido del archivo y el contenido leído se guarda en una variable cualquiera de tipo string.
            //aquí no se necesitan ciclos pues el método ReadToEnd() lee todo el contenido de una sola vez.
            string json = jsonStream.ReadToEnd();

            //Se cierra el archivo
            jsonStream.Close();

            //Se deserializa (convierte) la cadena json guardada en la variable, en la estructura que tiene la lista a donde se van a cargar los datos
            lista = JsonConvert.DeserializeObject<List<Alumno>>(json);
        }

        protected void ButtonNotas_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt16(TextBoxNota.Text);

            NotasTemp.Add(nota);

            GridView1.DataSource = NotasTemp;
            GridView1.DataBind();
        }

        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carne = TextBoxCarne.Text;
            alumno.Nombre= TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Notas = NotasTemp;

            alumnos.Add(alumno);

            NotasTemp.Clear();

            Guardar();

        }
    }
}