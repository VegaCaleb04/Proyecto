using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Programa
    {
        string idprograma;
        string nombre;

        public Programa(string idprograma, string nombre)
        {
            this.Idprograma = idprograma;
            this.Nombre = nombre;
        }
        public Programa()
        {
            Idprograma = idprograma;
            Nombre = nombre;
        }

        public string Idprograma { get => idprograma; set => idprograma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}