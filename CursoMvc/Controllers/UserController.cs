using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoMvc.Models;

namespace CursoMvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<Models.TableViewModels.UserTableViewModel> listaUser = new List<Models.TableViewModels.UserTableViewModel>();
            using (CursoMVCEntities db = new CursoMVCEntities())
            {
                listaUser = (from d in db.User
                            where d.StateId == 1
                            orderby d.email
                            select new Models.TableViewModels.UserTableViewModel
                            {
                                Email = d.email,
                                Id = d.id,
                                Edad = d.edad
                            }).ToList();
            }
            return View(listaUser);
        }
    }
}