using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Verificacion_de_evidencias.Models
{
    public class Semestre
    {
        int idSemestre;
        DateTime fecha_inicio;
        DateTime fecha_final;

        public Semestre(int idSemestre, DateTime fecha_inicio, DateTime fecha_final)
        {
            this.IdSemestre = idSemestre;
            this.Fecha_inicio = fecha_inicio;
            this.Fecha_final = fecha_final;
        }
        public Semestre()
        {
            IdSemestre = idSemestre;
            Fecha_inicio = DateTime.Now;
            Fecha_final = DateTime.Now;
        }

        public int IdSemestre { get => idSemestre; set => idSemestre = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_final { get => fecha_final; set => fecha_final = value; }
    }
}