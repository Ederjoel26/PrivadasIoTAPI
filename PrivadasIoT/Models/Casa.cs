using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivadasIoT.Models
{
    public class Casa
    {
        public int ID { get; set; }
        public int NumCasa { get; set; } 
        public int PrivadaID { get; set; }
        public virtual Privada Privada { get; set; }
        public bool Estatus { get; set; }
        public virtual List <Usuario> Usuarios { get; set; }
    }

    public class CasaDTO
    {
        public int ID { get; set; }
        public int NumCasa { get; set; }
        public int PrivadaID { get; set; }
        public bool Estatus { get; set; }
    }
}
