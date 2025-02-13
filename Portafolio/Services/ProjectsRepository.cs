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
                    Title = "Chat Application",
                    Description = "A chap application built with React",
                    Link   = "https://chat-app-lo.netlify.app/",
                    ImageURL = "/Images/chatapp.png"
                },
                 new Project()
                {
                    Title = "Weather App",
                    Description = "A weather app",
                    Link   = "https://weather-app-lo.netlify.app/",
                    ImageURL = "/Images/wapp.jpg"
                },
                  new Project()
                {
                    Title = "Voting system",
                    Description = "Landing Page for voting system",
                    Link   = "https://bright-frangollo-7c8e71.netlify.app/",
                    ImageURL = "/Images/ICON.png"
                },
                   new Project()
                {
                    Title = "SuperChat",
                    Description = "Chat app built with Firebase and JavaScript",
                    Link   = "https://jolly-bardeen-c7c855.netlify.app/",
                    ImageURL = "/Images/chatapp2.png"
                }
            };
        }
    }




}
