using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ng_google_io_onwebapi.Api
{
    public class ProjectController : ApiController
    {
        public class Project
        {
            public Project() { }
            public Project(int id, string name, string url, string description)
            {
                this.id = id;
                this.name = name;
                this.url = url;
                this.description = description;
            }

            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string description { get; set; }
        }

        public static List<Project> ProjectsDb = new List<Project>
        {
          new Project { id=1, name= "AngularJS",   url= "http://angularjs.org",   description= "Super-heroic web-framework."},
          new Project { id=2, name= "BackboneJS",  url= "http://backbonejs.org",  description= "Models for your apps."},
          new Project { id=3, name= "BatmanJS",    url= "http://batmanjs.org/",   description= "Quick and beautiful."},
          new Project { id=4, name= "Capucino",    url= "http://cappuccino.org/", description= "Objective-J."},
          new Project { id=5, name= "EmberJS",     url= "http://emberjs.com/",    description= "Ambitious web apps."},
          new Project { id=6, name= "GWT",         url= "https://developers.google.com/web-toolkit/", description= "JS in Java."},
          new Project { id=7, name= "jQuery",      url= "http://jquery.com/",     description= "Write less, do more."},
          new Project { id=8, name= "Knockout",    url= "http://knockoutjs.com/", description= "MVVM pattern."},
          new Project { id=9, name= "Sammy",       url= "http://sammyjs.org/",    description= "Small with class."},
          new Project { id=10, name= "Spine",      url= "http://spinejs.com/",    description= "Awesome MVC apps."},
          new Project { id=11, name= "SproutCore", url= "http://sproutcore.com/", description= "Innovative web-apps."}
        };

        private static int _nextId = 1000;

        public IEnumerable<Project> Get()
        {
            return ProjectsDb;
        }

        public Project Get(int id)
        {
            return ProjectsDb.FirstOrDefault(p=>p.id == id);
        }

        public void Post(Project newProject)
        {
            newProject.id = _nextId++;
            ProjectsDb.Add(newProject);
        }

        public void Post(int id, Project updatedProject)
        {
            var oldProject = ProjectsDb.First(p => p.id == id);
            oldProject.name = updatedProject.name;
            oldProject.url = updatedProject.url;
            oldProject.description = updatedProject.description;
        }

        public void Delete(int id)
        {
            ProjectsDb.Remove(ProjectsDb.First(p=>p.id == id));
        }
    }
}
