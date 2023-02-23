using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Asignatura
    {
        String idAsignatura;
        string FK_idSemestre;
        string FK_idPrograma;
        String nombre;

        public Asignatura(string idAsignatura, string fK_idSemestre, string fK_idPrograma, string nombre)
        {
            this.IdAsignatura = idAsignatura;
            FK_idSemestre1 = fK_idSemestre;
            FK_idPrograma1 = fK_idPrograma;
            this.Nombre = nombre;
        }

        public string IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public string FK_idSemestre1 { get => FK_idSemestre; set => FK_idSemestre = value; }
        public string FK_idPrograma1 { get => FK_idPrograma; set => FK_idPrograma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}