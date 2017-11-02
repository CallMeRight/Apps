using Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.BLL
{
    public class BaseBLL : IDisposable
    {
        public DBContainer db = new DBContainer();

        public void Dispose()
        {

        }
    }
}
