using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Net.Http;
using System.Web.Http;

namespace Verificacion_de_evidencias.Controllers
{
    public class Estudiantes : ApiController
    {
        string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proyecto\Verificacion_de_evidencias\Verificacion_de_evidencias\App_Data\Evidencias.mdf;Integrated Security=True";
        // GET: api/Clientes
        public IEnumerable<Models.Estudiantes> Get()
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Profesores> listadoEstudiantes = null;
            string consultaSql = "SELECT * FROM ESTUDIANTE";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Estudiantes
                {
                    IdEstudiante = r.Field<string>("IDESTUDIANTE"),
                    Nombre = r.Field<string>("NOMBRE"),
                    Apellido = r.Field<string>("APELLIDO"),
                    X = r.Field<string>("X"),
                    Y = r.Field<string>("Y")


                });
            listadoEstudiantes = myData.ToList();
            return listadoEstudiantes;
        }

        // GET api/<controller>/5
        public IEnumerable<Models.Profesores> Get(string id)
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Profesores> listadoEstudiantes = null;
            string consultaSql = "SELECT * FROM ESTUDIANTE WHERE IDESTUDIANTE='" + id + "'";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Estudiantes
                {
                    IdEstudiante = r.Field<string>("IDESTUDIANTE"),
                    Nombre = r.Field<string>("NOMBRE"),
                    Apellido = r.Field<string>("APELLIDO"),
                    X = r.Field<string>("X"),
                    Y = r.Field<string>("Y")


                });
            listadoEstudiantes = myData.ToList();
            return listadoEstudiantes;

        }

        // POST api/EvidenciaProfesores
        public IHttpActionResult Post(Models.Estudiantes objEstudiantes)
        {
            string comandoSql = string.Format("INSERT INTO ESTUDIANTE(IDESTUDIANTE,NOMBRE,APELLIDO,X,Y)VALUES('{0}','{1}','{2}','{3}','{4}','{5})", objEstudiantes.IdEstudiante, objEstudiantes.Nombre, objEstudiantes.Apellido, objEstudiantes.X, objEstudiantes.Y);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");


        }

        // PUT api/EvidenciaEstudiante/5
        public IHttpActionResult Put(Models.Estudiantes objEstudiantes)
        {
            string comandoSql = string.Format("UPDATE ESTUDIANTE SET NOMBRE='{1}',APELLIDO='{2}',X='{3}',Y='{4}',WHERE IDESTUDIANTE='{0}'", objEstudiantes.IdEstudiante, objEstudiantes.Nombre, objEstudiantes.Apellido, objEstudiantes.X, objEstudiantes.Y);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");


        }

        // DELETE api/EvidenciaProfesores/5
        public IHttpActionResult Delete(Models.Estudiantes ObjEstudiantes)
        {
            string comandoSql = String.Format("DELETE FROM ESTUDIANTE WHERE IDESTUDIANTE='{0}'", ObjEstudiantes.IdEstudiante);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo Modificar el registro");
        }
    }
}