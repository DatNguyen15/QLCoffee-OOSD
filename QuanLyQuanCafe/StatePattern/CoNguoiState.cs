using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StatePattern
{
    class CoNguoiState : State
    {
        public bool handleRequest()
        {
            return true;
        }
    }
}
