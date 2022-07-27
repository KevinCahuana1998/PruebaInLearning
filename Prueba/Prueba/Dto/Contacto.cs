using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dto
{
    public class Contacto
    {
        [Key]
        public int id_contacto { get; set; }
        public string nombre { get; set; }
        public int celular { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int id_empresa { get; set; }
    }
}
