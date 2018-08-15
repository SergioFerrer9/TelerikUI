using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Models;

namespace Telerik.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarPersona() {
            try
            {
                Model1 modelo = new Model1();
                List<Persona> generos = modelo.Database.SqlQuery<Persona>("spr_mostrarPersonas").ToList();
             
                return Json(generos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            } 
        }

        [HttpPost]
        public ActionResult Insertar(Persona modelo1) {
            try
            {
                //Conexión a base de datos
                Model1 modelo = new Model1();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("Nombre", modelo1.Nombre));
                parametros.Add(new SqlParameter("Apellido", modelo1.Apellido));
                parametros.Add(new SqlParameter("Telefono", modelo1.Telefono));
                parametros.Add(new SqlParameter("Album", modelo1.Album));
                parametros.Add(new SqlParameter("Cancion", modelo1.Cancion));

                List<Persona> persona = modelo.Database.SqlQuery<Persona>("spr_insertarPersonas @Nombre, @Apellido, @Telefono, @Album, @Cancion", parametros.ToArray()).ToList();
                return Json(persona, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
    
        }

        [HttpPost]
        public ActionResult Modificar(Persona modelo1) { 
            try{
                Model1 modelo = new Model1();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("id", modelo1.id));
                parametros.Add(new SqlParameter("Nombre", modelo1.Nombre));
                parametros.Add(new SqlParameter("Apellido", modelo1.Apellido));
                parametros.Add(new SqlParameter("Telefono", modelo1.Telefono));
                parametros.Add(new SqlParameter("Album", modelo1.Album));
                parametros.Add(new SqlParameter("Cancion", modelo1.Cancion));

                List<Persona> persona = modelo.Database.SqlQuery<Persona>("spr_modificarPersonas @id, @Nombre, @Apellido, @Telefono, @Album, @Cancion", parametros.ToArray()).ToList();
                return Json(persona, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
         
        
        }

        [HttpPost]
        public ActionResult Eliminar(Persona modelo1) {

            try {
                Model1 modelo = new Model1();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@id", modelo1.id));
                List<Persona> persona = modelo.Database.SqlQuery<Persona>("spr_eliminarPersona @id", parametros.ToArray()).ToList();        
                return Json(persona, JsonRequestBehavior.AllowGet);

            }catch(Exception ex){

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
  
        }

    }
}
