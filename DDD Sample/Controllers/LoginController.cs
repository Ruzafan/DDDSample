using DDDLayer.Application.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_Sample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        

        [HttpGet]
        public ActionResult Login(string email,string password )
        {
            LoginUseCase loginUseCase = new LoginUseCase();
            if(loginUseCase.Login(email, password))
            {
                //Está logado
                return View();
            }

            //No está logado
            return View();
        }
    }
}
