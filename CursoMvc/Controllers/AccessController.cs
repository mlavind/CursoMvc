using CursoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMvc.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(FormCollection formulario)
        {
            try
            {
                string usuario = formulario["user"].ToString();
                string password = formulario["password"].ToString();

                using (CursoMVCEntities db = new CursoMVCEntities())
                { 
                    var list = from d in db.User
                               where d.email == usuario && d.password == password && d.StateId == 1 
                               select d;

                    if (list.Count()>0)
                    {
                        User user = list.First();
                        Session["User"] = user;
                    }
                    else
                    {
                        return RedirectToAction("Index", "Access");
                    }
                };
            }
            catch (Exception e)
            {
                return Content("Ocurrio un error: "+ e.Message);
                throw;
            }
            return RedirectToAction("Index", "User");
        }

        //public ActionResult CerrarSession()
        //{
        //    Session["User"] = null;

        //    return HttpContext.Response.Redirect("~/Home/Index");
        //}

    }
}