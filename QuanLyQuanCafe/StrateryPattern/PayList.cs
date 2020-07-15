using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrateryPattern
{
    class PayList
    {
        private PayStratery stratery;
         public void setPay(PayStratery stratery)
        {
            this.stratery = stratery;
        }
        public float pay(float tien,int discount )
        {
            return stratery.TinhTien(tien,discount);
        }
    }
}
