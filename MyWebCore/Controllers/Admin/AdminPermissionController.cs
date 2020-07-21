using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebCore
{
    /// <summary>
    /// 需要权限验证的控制器继承
    /// </summary>
    [PermissionActionFilterAttribute]
    public class AdminPermissionController: PublicAdminController
    {

    }
}
