using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace MyWebCore.Areas.Admin.Controllers
{ 
    [Route("admin/main")]
    public class MainController : PublicAdminController
    {
        private IAdminAuthService _adminAuthService;

        public MainController(IAdminAuthService adminAuthService)
        {
            this._adminAuthService = adminAuthService;
        }
         
        [Route("",Name ="mainIndex")]
        public IActionResult Index()
        {   
            return View();
        }

        [Route("out",Name ="signOut")]
        public IActionResult SignOut()
        {
            _adminAuthService.signOut();
            return RedirectToRoute("adminLogin");
        }

    }
}