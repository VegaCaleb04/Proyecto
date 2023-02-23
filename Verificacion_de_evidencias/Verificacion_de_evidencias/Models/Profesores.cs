using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Profesores
    {
        string idProfesor;
        string FK_idAsignatura;
        string nombre;
        string apellido;
        string x;
        string y;

        public Profesores(string idProfesor, string fK_idAsignatura, string nombre, string apellido, string x, string y)
        {
            this.idProfesor = idProfesor;
            FK_idAsignatura = fK_idAsignatura;
            this.nombre = nombre;
            this.apellido = apellido;
            this.x = x;
            this.y = y;
        }
        public Profesores()
        {
            idProfesor = IdProfesor;
            FK_idAsignatura =FK_idAsignatura1;
            nombre = Nombre;
            apellido = Apellido;
            x = X;
            y =Y ;
        }

        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string FK_idAsignatura1 { get => FK_idAsignatura; set => FK_idAsignatura = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
    }
}