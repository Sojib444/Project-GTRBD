using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_Infrastructure.UniofWork
{
    public interface IUnitofWork:IDisposable
    {
        public void Saves();
    }
}
