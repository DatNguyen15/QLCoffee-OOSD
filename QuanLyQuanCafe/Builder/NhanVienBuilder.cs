using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Builder
{
    public class NhanVienBuilder : NhanSuBuilder
    {
        private ControllerNhanSu nhansu;
        public NhanVienBuilder()
        {
            nhansu = new ControllerNhanSu();
            nhansu.type = 0;
        }
        public void SetUserName(string UserName)
        {
            nhansu.username = UserName;
        }

        public void SetDisplayName(string DisplayName)
        {
            nhansu.displayname = DisplayName;
        }

        public ControllerNhanSu GetNhanSu()
        {
            return this.nhansu;
        }
    }
}
