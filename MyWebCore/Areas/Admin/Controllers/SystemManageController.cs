﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MyWebCore.Areas.Admin.Controllers
{ 
    [Function("系统管理", true, "menu-icon fa fa-desktop")]
    public class SystemManageController : AdminPermissionController
    { 

    }
}