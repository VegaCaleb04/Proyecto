using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Facultad
    {
        string idFacultad;
        string FK_idPrograma;
        string nombre;

        public Facultad(string idFacultad, string fK_idPrograma, string nombre)
        {
            this.idFacultad = idFacultad;
            FK_idPrograma = fK_idPrograma;
            this.nombre = nombre;
        }
        public Facultad()
        {
            idFacultad = IdFacultad;
            FK_idPrograma = FK_idPrograma1;
            nombre = Nombre;
        }

        public string IdFacultad { get => idFacultad; set => idFacultad = value; }
        public string FK_idPrograma1 { get => FK_idPrograma; set => FK_idPrograma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}