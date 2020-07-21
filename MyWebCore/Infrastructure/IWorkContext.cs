using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebCore
{
    public interface IWorkContext
    {
        /// <summary>
        /// 当前登录用户
        /// </summary>
        SysUser CurrentUser { get; }

        /// <summary>
        /// 当前登录用户的菜单
        /// </summary>
        List<Category> Categories { get; }
    }
}
