using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Chitiethoadon
    {
        [DisplayName("MÃ")]
        public string CthdMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpMa { get; set; }
        [DisplayName("HÌNH ẢNH")]
        public string HdMa { get; set; }
        [DisplayName("KHÁCH HÀNG")]
        public string KhMa { get; set; }
        [DisplayName("SỐ LƯỢNG")]
        public int CthdSoluong { get; set; }
        [DisplayName("TẠM TÍNH")]
        public double CthdTamtinh { get; set; }
        [DisplayName("PHÍ GIAO HÀNG")]
        public double CthdPhigiaohang { get; set; }
        [DisplayName("THÀNH TIỀN")]
        public double CthdThanhtien { get; set; }

        public virtual Hoadon HdMaNavigation { get; set; }
        public virtual Khachhangdat KhMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
