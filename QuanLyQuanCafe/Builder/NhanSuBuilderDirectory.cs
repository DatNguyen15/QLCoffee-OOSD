using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Builder
{
    public class NhanSuBuilderDirectory
    {
        public ControllerNhanSu Construct(NhanSuBuilder builder, string UserName, string DisplayName) 
        {
            builder.SetUserName(UserName);
            builder.SetDisplayName(DisplayName);
            ControllerNhanSu nhansu = builder.GetNhanSu();
            return nhansu;
        }
    }
}
