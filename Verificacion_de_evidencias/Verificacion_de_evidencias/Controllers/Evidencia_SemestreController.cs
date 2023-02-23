using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Verificacion_de_evidencias.Controllers
{
    public class Evidencia_SemestreController : ApiController
    {
        string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proyecto\Verificacion_de_evidencias\Verificacion_de_evidencias\App_Data\Evidencias.mdf;Integrated Security=True";
        // GET: api/Clientes
        public IEnumerable<Models.Semestre> Get()//Retorna un listado de la interfaz IEnumerable
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Semestre> listadoSemestre = null;
            string consultaSql = "SELECT * FROM SEMESTRE";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Semestre
                {
                   IdSemestre= r.Field<int>("IDSEMESTRE"),
                   Fecha_inicio= r.Field<DateTime>("FECHA_INICIO"),
                    Fecha_final=r.Field<DateTime>("FECHA_FINAL")


                });
            listadoSemestre= myData.ToList();
            return listadoSemestre;
        }

       
        // GET api/EVIDENCIAS_EMESTRE/5
        public IEnumerable<Models.Semestre> Get(int id)//Retorna un listado de la interfaz IEnumerable
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Semestre> listadoSemestre = null;
            string consultaSql = "SELECT * FROM SEMESTRE";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Semestre
                {
                    IdSemestre = r.Field<int>("IDSEMESTRE"),
                    Fecha_inicio = r.Field<DateTime>("FECHA_INICIO"),
                    Fecha_final = r.Field<DateTime>("FECHA_FINAL")


                });
            listadoSemestre = myData.ToList();
            return listadoSemestre;
        }

        // POST api/Evidencia_Semestre


        // PUT api/Evidencia_Semestre/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Evidencia_Semestre>/5
        public void Delete(int id)
        {
        }
    }
}