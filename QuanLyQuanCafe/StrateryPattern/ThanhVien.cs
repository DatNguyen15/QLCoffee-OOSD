using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrateryPattern
{
    class ThanhVien : PayStratery
    {
        public float TinhTien(float tien, int discount)
        {

            tien = tien * (100-discount) / 100;
           return tien;
        }
    }
}
