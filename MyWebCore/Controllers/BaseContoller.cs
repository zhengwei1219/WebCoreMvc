﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebCore
{
    public abstract class BaseContoller : Controller
    {
        private AjaxResult _ajaxResult;

        public BaseContoller()
        {
            this._ajaxResult = new AjaxResult();
        }

        /// <summary>
        /// ajax请求的数据结果
        /// </summary>
        public AjaxResult AjaxData
        {
            get
            {
                return _ajaxResult;
            }
        }




    }
}
