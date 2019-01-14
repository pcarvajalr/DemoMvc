using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DemoMvc.Controllers
{ 
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var idUsuarioActual = User.Identity.GetUserId();

                    var roleManager = new RoleManager<IdentityRole>
                        (new RoleStore<IdentityRole>(db));

                    var resultado = roleManager.Create(new IdentityRole("ApruebaPrestamos"));


                }
            }


            ///////////////////CREA UN NUEVO USUARIO AL INGRESAR AUTENTICADO A INDEX/HOME///////////

            //var estaautenticado = User.Identity.IsAuthenticated;
            //if (estaautenticado)
            //{
            //    var NombreUsuario = User.Identity.Name;
            //    var id = User.Identity.GetUserId();

            //    using (ApplicationDbContext db = new ApplicationDbContext())
            //    {
            //        var usuario = db.Users.Where(x => x.Id == id).FirstOrDefault();
            //        //var emailConfirmado = usuario.Email;

            //        var Administradordeusuarios = new UserManager<ApplicationUser>(
            //            new UserStore<ApplicationUser>(db));

            //        var user = new ApplicationUser();
            //        user.UserName = "rocio2";
            //        user.Email = "rocio2@ejemplo.com";
            //        user.PhoneNumber = "32058985";

            //        var resultado = Administradordeusuarios.Create(user, "Gold12.");

            //    }
            //}

            // //ALMACENA UN ROL(CREADO), BUSCAR LOS USUARIOS CON ESE ROL Y GENERA LISTA//
            //var roleName = "Nombre del rol";
            //var RoleId = context.Roles.Where(x => x.Name == roleName).Select(x => x.Id).First();
            //var users = context.Users.Where(u => u.Roles.Any(r => r.RoleId == RoleId)).ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}