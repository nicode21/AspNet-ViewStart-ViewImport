using Microsoft.AspNetCore.Mvc;
using GrowMark.Models;
using System.Drawing;
using GrowMark.ViewModels;

namespace GrowMark.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Feature f1 = new()
            {
                Id = 1,
                Logo = "icon-1.png",
                Title = "Award Winning",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam"
            };

            Feature f2 = new()
            {
                Id = 2,
                Logo = "icon-2.png",
                Title = "Professional Staff",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam"
            };

            Feature f3 = new()
            {
                Id = 3,
                Logo = "icon-3.png",
                Title = "Fair Prices",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam"
            };

            Feature f4 = new()
            {
                Id = 4,
                Logo = "icon-4.png",
                Title = "24/7 Support",
                Description = "Stet stet justo dolor sed duo. Ut clita sea sit ipsum diam"
            };

            Service s1 = new()
            {
                Id = 1,
                Logo = "icon-5.png",
                Title = "Digital Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Service s2 = new()
            {
                Id = 2,
                Logo = "icon-6.png",
                Title = "Internet Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Service s3 = new()
            {
                Id = 3,
                Logo = "icon-7.png",
                Title = "Content Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Service s4 = new()
            {
                Id = 4,
                Logo = "icon-8.png",
                Title = "Social Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Service s5 = new()
            {
                Id = 5,
                Logo = "icon-9.png",
                Title = "B2B Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Service s6 = new()
            {
                Id = 6,
                Logo = "icon-10.png",
                Title = "E-mail Marketing",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem sed diam stet"
            };

            Project p1 = new()
            {
                Id = 1,
                Image = "project-1.jpg",
                Title = "Data Analytics & Insights",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem"
            };

            Project p2 = new()
            {
                Id = 2,
                Image = "project-2.jpg",
                Title = "Marketing Content Strategy",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem"
            };

            Project p3 = new()
            {
                Id = 3,
                Image = "project-3.jpg",
                Title = "Business Target Market",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem"
            };

            Project p4 = new()
            {
                Id = 4,
                Image = "project-4.jpg",
                Title = "Social Marketing Strategy",
                Description = "Erat ipsum justo amet duo et elitr dolor, est duo duo eos lorem"
            };

            OurTeam t1 = new()
            {
                Id = 1,
                Image = "team-1.jpg",
                Name = "Alex Robin",
                Position = "Founder & CEO"
            };

            OurTeam t2 = new()
            {
                Id = 2,
                Image = "team-2.jpg",
                Name = "Adam Crew",
                Position = "Co Founder"
            };

            OurTeam t3 = new()
            {
                Id = 3,
                Image = "team-3.jpg",
                Name = "Boris Johnson",
                Position = "Executive Manager"
            };

            OurTeam t4 = new()
            {
                Id = 4,
                Image = "team-4.jpg",
                Name = "Robert Jordan",
                Position = "Digital Marketer"
            };

            Testimonial ts1 = new()
            {
                Id = 1,
                ProfileImage = "testimonial-1.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts2 = new()
            {
                Id = 2,
                ProfileImage = "testimonial-2.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts3 = new()
            {
                Id = 3,
                ProfileImage = "testimonial-3.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };

            Testimonial ts4 = new()
            {
                Id = 4,
                ProfileImage = "testimonial-4.jpg",
                Description = "Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et\r\n                    sit, sed stet lorem sit clita duo justo",
                Name = "Client Name",
                Position = "Profession"
            };


            HomeVM home = new ()
            {
                Features = new List<Feature>() {f1,f2,f3,f4},
                Services = new List<Service>() {s1,s2,s3,s4,s5,s6},
                Projects = new List<Project>() {p1,p2,p3,p4},
                OurTeams = new List<OurTeam>() {t1,t2,t3,t4},
                Testimonials = new List<Testimonial>() {ts1,ts2,ts3,ts4}
            };

            return View(home);
        }
    }
}
