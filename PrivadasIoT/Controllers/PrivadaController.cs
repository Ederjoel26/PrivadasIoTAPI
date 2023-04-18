using PrivadasIoT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrivadasIoT.Controllers
{
    public class PrivadaController : ApiController
    {
        private Modelo bd = new Modelo();

        [ActionName("Insertar")]
        [HttpPost]
        public bool Insertar(Privada privada)
        {
            try
            {
                var existe = bd.Privada.Where(c => c.NumeroSerie == privada.NumeroSerie || c.Nombre == privada.Nombre);
                if(existe.Count() == 0)
                {
                    bd.Privada.Add(privada);
                    bd.SaveChanges();

                    return true;
                }

                return false;

            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
