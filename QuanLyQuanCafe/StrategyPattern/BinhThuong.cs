using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrategyPattern
{
    class BinhThuong : PayStrategy
    {
        public float TinhTien(float tien, int discount)
        {
            discount = 0;
            return tien;
        }
    }
}
