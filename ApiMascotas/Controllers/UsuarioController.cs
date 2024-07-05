using Logica_app_Mascotas;
using Logica_app_Mascotas.Entidades.Response;
using Logica_app_Mascotas.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiMascotas.Controllers
{
    public class UsuarioController: ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Registro_Usuario/IngresarUsuario")]

        public ResIngresarUsuario IngresarUsuario(ReqIngresarUsuario req)
        {
            return new LogIngresarUsuario().IngresarUsuario(req);
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/login/IngresarLogin")]
        public Reslogin Ingresarlogin(Reqlogin req)
        { 
            return new LogLogin().Ingresarlogin(req);
         
        }
       
    }
}