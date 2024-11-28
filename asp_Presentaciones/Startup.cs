using lib_Comunicaciones.Implementaciones;
using lib_Comunicaciones.Interfaces;
using lib_Presentaciones.Implementaciones;
using lib_Presentaciones.Interfaces;

namespace asp_Presentaciones
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            // Comunicaciones
            services.AddScoped<IAsignaturasComunicacion, AsignaturasComunicacion>();
            services.AddScoped<ICursosComunicacion, CursosComunicacion>();
            services.AddScoped<IDepartamentosComunicacion, DepartamentosComunicacion>();
            services.AddScoped<IEstudiantesComunicacion, EstudiantesComunicacion>();
            services.AddScoped<IFacultadesComunicacion, FacultadesComunicacion>();
            services.AddScoped<IProfesoresComunicacion, ProfesoresComunicacion>();
            // Presentaciones
            services.AddScoped<IAsignaturasPresentacion, AsignaturasPresentacion>();
            services.AddScoped<ICursosPresentacion, CursosPresentacion>();
            services.AddScoped<IDepartamentosPresentacion, DepartamentosPresentacion>();
            services.AddScoped<IEstudiantesPresentacion, EstudiantesPresentacion>();
            services.AddScoped<IFacultadesPresentacion, FacultadesPresentacion>();
            services.AddScoped<IProfesoresPresentacion, ProfesoresPresentacion>();


            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseSession();
            app.Run();
        }
    }
}
