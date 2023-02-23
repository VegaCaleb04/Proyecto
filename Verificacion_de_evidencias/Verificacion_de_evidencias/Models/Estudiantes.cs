using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Estudiantes
    {
        string idEstudiante;
        string FK_idAsignatura;
        string nombre;
        string apellido;
        string x;
        string y;

        public Estudiantes(string idEstudiante, string fK_idAsignatura, string nombre, string apellido, string x, string y)
        {
            this.IdEstudiante = idEstudiante;
            FK_idAsignatura1 = fK_idAsignatura;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.X = x;
            this.Y = y;
        }
        public Estudiantes()
        {
            IdEstudiante = idEstudiante;
            FK_idAsignatura1 = FK_idAsignatura1;
            Nombre = nombre;
            Apellido = apellido;
            X = x;
            Y = y;
        }

        public string IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string FK_idAsignatura1 { get => FK_idAsignatura; set => FK_idAsignatura = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
    }
}