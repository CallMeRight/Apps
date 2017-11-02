using Apps.IDAL;
using Apps.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DAL
{
    public class SysRoleRepository : IDisposable, ISysRoleRepository
    {
        public IQueryable<SysRole> GetList(DBContainer db)
        {
            IQueryable<SysRole> list = db.SysRole.AsQueryable();
            return list;
        }

        public int Create(SysRole entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysRole.Add(entity);
                return db.SaveChanges();
            }
        }

        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysRole entity = db.SysRole.SingleOrDefault(a => a.Id == id);
                if (entity != null)
                {

                    db.SysRole.Remove(entity);
                }
                return db.SaveChanges();
            }
        }

        public int Edit(SysRole entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysRole.Attach(entity);
                db.Entry<SysRole>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public SysRole GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysRole.SingleOrDefault(a => a.Id == id);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysRole entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
