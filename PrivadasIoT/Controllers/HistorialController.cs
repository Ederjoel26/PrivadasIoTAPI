using PrivadasIoT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrivadasIoT.Controllers
{
    public class HistorialController : ApiController
    {
        private Modelo bd = new Modelo();

        [ActionName("Insertar")]
        [HttpPost]
        public bool Insertar(Historial historial)
        {
            try
            {
                bd.Historial.Add(historial);
                bd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [ActionName("ObtenerHistorialCasa")]
        [HttpGet]
        public List<HistorialDTO> ObtenerHistorialCasa(int ID)
        {
            var historialCasa = (from historial in bd.Historial
                                select new HistorialDTO
                                {
                                    ID = historial.ID,
                                    FechaEpoch = historial.FechaEpoch,
                                    NumCasa = historial.NumCasa,
                                    Observacion = historial.Observacion,
                                    PrivadaID = historial.PrivadaID,
                                    Usuario = historial.Usuario,
                                }).ToList();
            return historialCasa;
        }
    }
}
