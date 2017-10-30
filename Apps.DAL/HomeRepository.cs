using Apps.IDAL;
using Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DAL
{
    public class HomeRepository : IHomeRepository, IDisposable
    {
        public List<SysModule> GetMenuByPersonId(string personId, string moduleId)
        {
            using (DBContainer db = new DBContainer())
            {
                ////得到角色
                //var roles = from r in db.SysRole
                //            from u in db.SysUser
                //            where u.Id == personId
                //            select r;
                ////得到module列表
                //var menus = (from m in db.SysModule
                //             from ri in db.SysRight
                //             where ri.ModuleId == m.Id
                //             where roles.Any(r => r.Id == ri.RoleId)
                //             where ri.Rightflag == true
                //             where m.ParentId == moduleId
                //             where m.Id != "0"
                //             select m)
                //.Distinct().OrderBy(a => a.Sort).ToList();


                //var menus =
                //(
                //    from m in db.SysModule
                //    join rl in db.SysRight
                //    on m.Id equals rl.ModuleId
                //    join r in
                //        (from r in db.SysRole
                //         from u in db.SysUser
                //         where u.Id == personId
                //         select r)
                //    on rl.RoleId equals r.Id
                //    where rl.Rightflag == true
                //    where m.ParentId == moduleId
                //    where m.Id != "0"
                //    select m
                //          ).Distinct().OrderBy(a => a.Sort).ToList();
                //return menus;

                var menus =
                    (
                        from m in db.SysModule
                        where m.ParentId == moduleId
                        where m.Id != "0"
                        select m
                              ).Distinct().OrderBy(a => a.Sort).ToList();
                return menus;

            }
        }

        public void Dispose()
        {

        }
    }
}
