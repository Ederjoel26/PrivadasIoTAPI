using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrivadasIoT.Models
{
    public class Privada
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String NumeroSerie { get; set; }
        public String Contraseña { get; set; }
        public String NombreAdministrador { get; set; }
        public String ContraseñaAdministrador { get; set; }
        public bool Estatus { get; set; }
        public virtual List<Casa> Casas { get; set;}
        public virtual List<Historial> Historiales { get; set;}
    }

    public class PrivadaDTO
    { 
        public String Nombre { get; set; }
        public String NumeroSerie { get; set; }
        public String Contraseña { get; set; }
        public String NombreAdministrador { get; set; }
        public String ContraseñaAdministrador { get; set; }
        public bool Estatus { get; set; }
    }
}