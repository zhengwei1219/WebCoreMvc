﻿
using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using Model;

namespace MyWebCore
{
    public class WorkContext : IWorkContext
    {
        private IAdminAuthService _authenticationService;

        public WorkContext(IAdminAuthService authenticationService)
        {
            this._authenticationService = authenticationService;
        }

        /// <summary>
        /// 当前登录用户
        /// </summary>
        public SysUser CurrentUser
        {
            get { return _authenticationService.getCurrentUser(); }
        }

        /// <summary>
        /// 当前登录用户菜单
        /// </summary>
        public List<Category> Categories {
            get
            {
              return _authenticationService.getMyCategories();
            }
        }
    }
}
