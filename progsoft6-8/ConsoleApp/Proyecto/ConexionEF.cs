using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsoleApp.Proyecto
{
    public class ConexionEF
    {
        private string string_conexion = "server=DESKTOP-VAKQHL3\\DEV;database=DB_Universidad;uid=sa;pwd=HHG67hgjhg67t!;TrustServerCertificate=true;";
        // server=localhost;database=db_facturas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_facturas;Integrated Security=True;TrustServerCertificate=true;

        public ConexionEF()
        {
            Console.WriteLine("\n\n\n\n CONEXION EF A BASE DE DATOS");
        }

        public void ObtenerEstudiantes()
        {
            using var conexion = new Conexion();
            conexion.StringConnection = this.string_conexion;

            var lista_estudiantes = conexion.Estudiantes!.ToList();
            foreach (var estudiante in lista_estudiantes)
            {
                Console.WriteLine(estudiante.Id.ToString() + "|" + estudiante.Nombre);
            }
        }
    }

    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Estudiantes>? Estudiantes { get; set; }
    }
}