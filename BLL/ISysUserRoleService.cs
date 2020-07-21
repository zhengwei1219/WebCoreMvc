using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface ISysUserRoleService
    {
        /// <summary>
        /// 获取所有的数据
        /// </summary>
        /// <returns></returns>
        List<SysUserRole> getAll();

        /// <summary>
        /// 移除缓存
        /// </summary>
        void removeCache();
    }
}
