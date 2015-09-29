using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public class SkillGroup
        {
            private string _name;
            private string[] _skills;

            public SkillGroup(string name, string[] skills)
            {
                _name = name;
                _skills = skills;
            }

            public string Name
            {
                get{ return _name;}
            }

            public string[] Skills
            {
                get { return _skills; }
            }
        }

        public ActionResult Index()
        {
            ViewBag.Name = "Joel Colaco";
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.SubText = "Full Stack Developer - User Experience Designer";

            //Technology
            string[] Technology = new string[] { "Java", "C#", "C++", "SQL" };
            SkillGroup SkillGroup1 = new SkillGroup("Technology", Technology);
            ViewBag.SkillGroup1 = SkillGroup1;
            
            //Web
            string[] Web = new string[] { "Javascript", "HTML5", "CSS3" };
            SkillGroup SkillGroup2 = new SkillGroup("Web", Web);
            ViewBag.SkillGroup2 = SkillGroup2;

            //Design
            string[] Design = new string[] { "Photoshop", "LightRoom", "Illustrator" };
            SkillGroup SkillGroup3 = new SkillGroup("Design", Design);
            ViewBag.SkillGroup3 = SkillGroup3;

            //Other
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
