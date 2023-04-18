using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace PrivadasIoT.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public String Correo { get; set; }
        public String Contra { get; set; }
        public int CasaID { get; set; }
        public virtual Casa Casa { get; set; }
        public bool Estatus { get; set; }
    }

    public class UsuarioDTO
    {
        public int ID { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        public int CasaID { get; set; }
        public bool Estatus { get; set; }
    }
}