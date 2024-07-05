using Logica_app_Mascotas.Acceso_A_Datos;
using Logica_app_Mascotas.Entidades.Response;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_app_Mascotas.Logica
{
    public class LogIngresarUsuario
    {
        public ResIngresarUsuario IngresarUsuario(ReqIngresarUsuario req)
        {
            ResIngresarUsuario res = new ResIngresarUsuario();
            
            if (req==null)
                {
                res.resultado = false;
                res.error = "No se recibió la información necesaria para ingresar el usuario";
                
            }if (String.IsNullOrEmpty(req.registro_Usuario.Nombre))

                {
                res.resultado = false;
                res.error = "No se recibió el nombre del usuario";

            }if (String.IsNullOrEmpty(req.registro_Usuario.Apellidos))
                {
                    res.resultado = false;
                    res.error = "No se recibió el apellido del usuario";
             }if (String.IsNullOrEmpty(req.registro_Usuario.Correo_Electronico))

                {
                res.resultado = false;
                res.error = "No se recibió el correo electrónico del usuario";  

                }if (String.IsNullOrEmpty(req.registro_Usuario.Password))
            {
                res.resultado = false;
                res.error = "No se recibió la contraseña del usuario";

            } if (req.registro_Usuario.numeroverificacion == null)
            {
                res.resultado = false;
                res.error = "No se recibió el número de verificación";
            }
            else
            {
                try
                {
                    int? idReturn = 0;
                    int? idError = 0;
                    string errorDescripcion = null;

                    ConexionDataContext LINQ = new ConexionDataContext();
                    LINQ.SP_INSERTAR_USUARIO1(req.registro_Usuario.Nombre, req.registro_Usuario.Apellidos, req.registro_Usuario.Correo_Electronico,
                    req.registro_Usuario.Password, req.registro_Usuario.numeroverificacion,ref idReturn,ref idError,ref errorDescripcion);

                    if (idReturn == 0)
                    {
                        res.resultado = false;
                        res.error = "Error al ingresar el usuario: " + errorDescripcion;
                    }
                    else
                    {
                        res.resultado = true;
                    }

                } catch (Exception ex)
                {
                    res.resultado = false;
                    res.error = "se cayo la bd no se por que: " + ex.Message;
                }
               
                

            }
             
                 

            
            return res;
        }



    }
}
