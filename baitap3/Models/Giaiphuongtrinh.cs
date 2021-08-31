using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baitap3.Models
{
    public class Giaiphuongtrinh
    {
        
        public int SoA { get; set; }
        public int SoB { get; set; }
        public int TinhTong(int SoA, int SoB)
        {
            int tong = 0;
            tong = SoA + SoB;
            return tong;
        }
    }
}