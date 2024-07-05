using Logica_app_Mascotas.Acceso_A_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_app_Mascotas
{
    public class LogLogin
    {

        public Reslogin Ingresarlogin(Reqlogin req)
        {
            Reslogin res = new Reslogin();

            if(req==null)
                {
                res.resultado = false;
                res.error = "campovacio";
            }
            if(String.IsNullOrEmpty(req.login.Correo_Electronico))
                {
                res.resultado = false;
                res.error = "error ";
            }
            if (String.IsNullOrEmpty(req.login.Contrasena))
            {
                res.resultado = false;
                res.error = "error ";
            }
            else
            {
                int? id_usuario = 0;
                int? estado = 0;
                string nombre = "";
                string apellido = "";
                int? eErrorid = 0;
                string errorDescripcion = null;


                try { 
                
                    ConexionDataContext Linq = new ConexionDataContext();
                    Linq.SP_LOGIN(req.login.Correo_Electronico, req.login.Contrasena,ref id_usuario,ref estado,ref nombre,
                        ref apellido,ref eErrorid,ref errorDescripcion);
                  
                    if(id_usuario==0)
                        {
                        res.resultado = false;
                        res.error = "error ";
                    }
                    else
                    {
                        res.resultado = true;
                        
                    }
     
                }catch(Exception ex)
                {
                    res.resultado = false;
                    res.error = "fallo en base de datos "+ ex.Message;
                }                                        
            
            }
         
            return res;
        }
    }
}
