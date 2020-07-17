﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.StrategyPattern
{
    class PayList
    {
        private PayStrategy stratery;
         public void setPay(PayStrategy stratery)
        {
            this.stratery = stratery;
        }
        public float pay(float tien,int discount )
        {
            return stratery.TinhTien(tien,discount);
        }
    }
}
