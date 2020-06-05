using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chitiethoadon
    {
        public string CthdMa { get; set; }
        public string SpMa { get; set; }
        public string HdMa { get; set; }
        public string KhMa { get; set; }
        public int CthdSoluong { get; set; }
        public double CthdTamtinh { get; set; }
        public double CthdPhigiaohang { get; set; }
        public double CthdThanhtien { get; set; }

        public virtual Hoadon HdMaNavigation { get; set; }
        public virtual Khachhangdat KhMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
