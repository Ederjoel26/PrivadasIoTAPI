using PrivadasIoT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrivadasIoT.Controllers
{
    public class CasaController : ApiController
    {
        private Modelo bd = new Modelo();

        [ActionName("Insertar")]
        [HttpPost]
        public bool Insertar(Casa casa)
        {
            try
            {
                bd.Casa.Add(casa);
                bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [ActionName("ObtenerCasas")]
        [HttpGet]
        public List<CasaDTO> ObtenerCasas()
        {
            var casas = (from casa in bd.Casa
                        select new CasaDTO
                        {
                            ID = casa.ID,
                            Estatus = casa.Estatus,
                            NumCasa = casa.NumCasa,
                            PrivadaID = casa.PrivadaID,
                        }).ToList();
            return casas;
        }
    }
}
