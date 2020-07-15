using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StatePattern
{
    class TableContext
    {
        private State state;
        public void  setState(string s)
        {
            if (s == "Trống")
                this.state = new TrongState();
            else
                this.state = new CoNguoiState();
        }
        public bool AppleState()
        {
           return state.handleRequest();

        }

    }
}
