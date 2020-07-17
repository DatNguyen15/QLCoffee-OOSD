using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrategyPattern
{
    interface PayStrategy
    {
        float TinhTien(float tien, int discount);
    }
}
