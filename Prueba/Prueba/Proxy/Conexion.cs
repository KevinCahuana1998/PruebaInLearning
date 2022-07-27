using Microsoft.EntityFrameworkCore;
using Prueba.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Proxy
{
    public class Conexion:DbContext
    {
        public Conexion(DbContextOptions<Conexion> options): base(options) {
        }

        public DbSet<Contacto> Contacto { get; set; }
}
}
