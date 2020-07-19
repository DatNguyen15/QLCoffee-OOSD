using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Builder
{
    public interface NhanSuBuilder
    {
        //tạo các function 
        void SetUserName(string UserName);
        void SetDisplayName(string DisplayName);
      
        ControllerNhanSu GetNhanSu();
    }
}
