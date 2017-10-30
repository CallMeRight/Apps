using Apps.IBLL;
using Apps.IDAL;
using Apps.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Apps.BLL
{
    public class SysUserBLL : BaseBLL, ISysUserBLL
    {
        [Dependency]
        public ISysRightRepository sysRightRepository { get; set; }
        public List<permModel> GetPermission(string accountid, string controller)
        {
            return sysRightRepository.GetPermission(accountid, controller);
        }
    }
}
