using Portafolio.Models;

namespace Portafolio.Services
{

    public interface IProjectsRepository
    {
        List<Project> GetProjects();
    }
    public class ProjectsRepository : IProjectsRepository
    {

        public List<Project> GetProjects()
        {
            return new List<Project>()
            {
                new Project()
                {
                    Title = "Punto de venta",
                    Description = "Sistema de punto de venta creado por laravel y conexion a apis rest .net",
                    Link   = "https://erp-demo.sofindra.com/",
                    ImageURL = "/Images/puntoventa.png"
                },
                 new Project()
                {
                    Title = "Pagina landing",
                    Description = "Pagina landing creada para hacer publicidad a la empresa",
                    Link   = "https://ainext-usa.com/",
                    ImageURL = "/Images/ainext.png"
                },
                //  new Project()
                //{
                //    Title = "Sistema de manejo de presupuestos",
                //    Description = "Llevear el gasto diario de un negocio o gastos personales",
                //    Link   = "https://contabilidad.sofindra.com",
                //    ImageURL = "/Images/ICON.png"
                //},
                //   new Project()
                //{
                //    Title = "HelpDesk",
                //    Description = "Sistema de tickets para soporte",
                //    Link   = "https://jolly-bardeen-c7c855.netlify.app/",
                //    ImageURL = "/Images/chatapp2.png"
                //},
                //    new Project()
                //{
                //    Title = "Sistema de extraccion de rutas por txt",
                //    Description = "Sistea que hace un historial de todas las cotizaciones hechas por un software en especifico",
                //    Link   = "https://jolly-bardeen-c7c855.netlify.app/",
                //    ImageURL = "/Images/chatapp2.png"
                //}

            };
        }
    }




}
