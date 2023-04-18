using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivadasIoT.Models
{
    public class Historial
    {
        public int  ID { get; set; }
        public int NumCasa { get; set; }
        public String Observacion { get; set; }
        public String Usuario { get; set; }
        public int FechaEpoch { get; set; } 
        public int PrivadaID { get; set; }
        public virtual Privada Privada { get; set; }
    }

    public class HistorialDTO
    {
        public int ID { get; set; }
        public int NumCasa { get; set; }
        public String Observacion { get; set; }
        public String Usuario { get; set; }
        public int FechaEpoch { get; set; }
        public int PrivadaID { get; set; }
    }
}   