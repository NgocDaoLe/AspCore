using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Khachhangdat
    {
        public Khachhangdat()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public string KhMa { get; set; }
        public string KhTen { get; set; }
        public string KhSdt { get; set; }
        public string KhEmail { get; set; }
        public string KhDiachi { get; set; }
        public string KhUsername { get; set; }
        public string KhPassword { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
