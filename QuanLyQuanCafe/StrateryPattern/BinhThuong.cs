using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrateryPattern
{
    class BinhThuong : PayStratery
    {
        public float TinhTien(float tien, int discount)
        {
            discount = 0;
            return tien;
        }
    }
}
