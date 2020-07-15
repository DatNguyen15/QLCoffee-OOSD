using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StatePattern
{
    class TrongState : State
    {
        public bool handleRequest()
        {
            return false;
        }
    }
}
