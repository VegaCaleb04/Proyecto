using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data;
using System.Web.Http;

namespace Verificacion_de_evidencias.Controllers
{
    public class EvidenciaFacultadController : ApiController
    {

        string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proyecto\Verificacion_de_evidencias\Verificacion_de_evidencias\App_Data\Evidencias.mdf;Integrated Security=True";
        // GET: api/Clientes
        public IEnumerable<Models.Facultad> Get()
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Semestre> listadoFacultad = null;
            string consultaSql = "SELECT * FROM FACULTAD";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Facultad
                {
                    IdFacultad = r.Field<string>("IDFACULTAD"),
                    Nombre = r.Field<string>("NOMBRE")
                });
            listadoFacultad = myData.ToList();
            return listadoFacultad;
        }

        // GET api/<controller>/5
        public IEnumerable<Models.Facultad> Get(string id)
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Semestre> listadoFacultad = null;
            string consultaSql = "SELECT * FROM FACULTAD WHERE IDFACULTAD='" + id + "'";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Facultad
                {
                    IdFacultad = r.Field<string>("IDFACULTAD"),
                    Nombre = r.Field<string>("NOMBRE")
                });
            listadoFacultad = myData.ToList();
            return listadoFacultad;
        }

        // POST api/<controller>
        public IHttpActionResult Post(Models.Facultad objFacultad)
        {
            string comandoSql = string.Format("INSERT INTO FACULTAD(IDFACULTAD,NOMBRE)VALUES('{0}','{1}','{2}')", objFacultad.IdFacultad, objFacultad.Nombre);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");

        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(Models.Facultad objFacultad)
        {
            string comandoSql = string.Format("UPDATE FACULTAD SET NOMBRE='{1}', WEHERE= IDFACULTAD= '{0}'", objFacultad.IdFacultad, objFacultad.Nombre);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}