using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Verificacion_de_evidencias.Controllers
{
    public class EvidenciaProfesoresController : ApiController
    {
        string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proyecto\Verificacion_de_evidencias\Verificacion_de_evidencias\App_Data\Evidencias.mdf;Integrated Security=True";
        // GET: api/Clientes
        public IEnumerable<Models.Profesores> Get()
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Profesores> listadoProfesores = null;
            string consultaSql = "SELECT * FROM PROFESORES";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Profesores
                {
                   IdProfesor = r.Field<string>("IDPROFESOR"),
                   Nombre = r.Field<string>("NOMBRE"),
                   Apellido=r.Field<string>("APELLIDO"),
                   X= r.Field<string>("X"),
                   Y = r.Field<string>("Y")


                });
            listadoProfesores = myData.ToList();
            return listadoProfesores;
        }

        // GET api/<controller>/5
        public IEnumerable<Models.Profesores> Get(string id)
        {
            DataSet objDataSet = null;//Guarda el resultado de la consulta

            IEnumerable<Models.Profesores> listadoProfesores = null;
            string consultaSql = "SELECT * FROM PROFESORES WHERE IDPROFESOR='"+id+"'";
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            objDataSet = objControlConexion.ejecutarConsultasSql(consultaSql);
            var myData = objDataSet.Tables[0].AsEnumerable().Select(//var es para a una variable cualquiera asignarle el tipo que sea 
                r => new Models.Profesores
                {
                    IdProfesor = r.Field<string>("IDPROFESOR"),
                    Nombre = r.Field<string>("NOMBRE"),
                    Apellido = r.Field<string>("APELLIDO"),
                    X = r.Field<string>("X"),
                    Y = r.Field<string>("Y")


                });
            listadoProfesores = myData.ToList();
            return listadoProfesores;

        }

        // POST api/EvidenciaProfesores
        public IHttpActionResult Post(Models.Profesores objProfesores)
        {
            string comandoSql = string.Format("INSERT INTO PROFESOR(IDPROFESOR,NOMBRE,APELLIDO,X,Y)VALUES('{0}','{1}','{2}','{3}','{4}','{5})", objProfesores.IdProfesor, objProfesores.Nombre, objProfesores.Apellido, objProfesores.X, objProfesores.Y);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");


        }

        // PUT api/EvidenciaProfesores/5
        public IHttpActionResult Put(Models.Profesores objProfesores)
        { 
            string comandoSql = string.Format("UPDATE PROFESOR SET NOMBRE='{1}',APELLIDO='{2}',X='{3}',Y='{4}',WHERE IDPROFESOR='{0}'", objProfesores.IdProfesor, objProfesores.Nombre, objProfesores.Apellido, objProfesores.X, objProfesores.Y);
        ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
        objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo guardar el registro");
        

        }

        // DELETE api/EvidenciaProfesores/5
        public IHttpActionResult Delete(Models.Profesores objProfesores)
        {
            string comandoSql = String.Format("DELETE FROM PROFESOR WHERE IDPROFESOR='{0}'",objProfesores.IdProfesor);
            ControlConexion objControlConexion = new ControlConexion(cadenaConexion);
            objControlConexion.abrirBD();
            string msg = objControlConexion.ejecutarComandoSQL(comandoSql);
            if (msg == "ok") return Content(HttpStatusCode.Created, "Transacción exitosa");
            else return Content(HttpStatusCode.Conflict, "No se pudo Modificar el registro");
        }
    }
}