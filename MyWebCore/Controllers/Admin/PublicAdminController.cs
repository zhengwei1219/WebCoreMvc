using Common;

using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebCore
{
    /// <summary>
    /// 
    /// </summary>
    [AdminAuthFilter] 
    public class PublicAdminController : AdminAreaController
    {
        private IWorkContext _workContext;

        public PublicAdminController()
        {
            this._workContext = EnginContext.Current.Resolve<IWorkContext>();
        }

        /// <summary>
        /// 当前工作上下文
        /// </summary>
        public IWorkContext WorkContext { get { return _workContext; } }
    }


}
