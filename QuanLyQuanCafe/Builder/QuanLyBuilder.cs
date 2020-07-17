using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Builder
{
     
    public class QuanLyBuilder : NhanSuBuilder
    { 
        private ControllerNhanSu nhansu;
        public QuanLyBuilder()
        {
            nhansu = new ControllerNhanSu();
            nhansu.type = 1;
        }
        public void SetUserName(string UserName)
        {
            nhansu.username= UserName;
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
