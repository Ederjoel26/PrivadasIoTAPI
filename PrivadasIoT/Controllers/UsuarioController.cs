using PrivadasIoT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrivadasIoT.Controllers
{
    public class UsuarioController : ApiController
    {
        private Modelo bd = new Modelo();

        [ActionName("Insertar")]
        [HttpPost]
        public bool Insertar(Usuario usuario)
        {

            try
            {
                var usuarioExistente = bd.Usuario.Where(u => u.Correo == usuario.Correo);
                if (usuarioExistente.Count() == 0)
                {
                    bd.Usuario.Add(usuario);
                    bd.SaveChanges();
                    return true;
                }
                return false;
            } catch (Exception ex)
            {
                return false;
            }

        }

        [ActionName("ObtenerUsuarios")]
        [HttpGet]
        public List<UsuarioDTO> ObtenerUsuarios()
        {
            var usuarios = (from usuario in bd.Usuario
                            select new UsuarioDTO
                            {
                                ID = usuario.ID,
                                Correo = usuario.Correo,
                                CasaID = usuario.CasaID,
                                Estatus = usuario.Estatus,
                                Contra = usuario.Contra,
                            }).ToList();
            return usuarios;
        }

        [ActionName("VerificarUsuario")]
        [HttpGet]
        public UsuarioDTO VerificarUsuario(string correo, string contra)
        {
            var usuario = (from u in bd.Usuario
                          where u.Correo == correo && u.Contra == contra
                          select new UsuarioDTO
                          {
                              ID = u.ID,
                              CasaID = u.CasaID,
                              Estatus = u.Estatus,
                              Contra = u.Contra,
                              Correo = u.Correo
                          }).FirstOrDefault();
            return usuario;
        }
    }
}
