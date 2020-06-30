using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitietchude = new HashSet<Chitietchude>();
            Chitiethinhthuc = new HashSet<Chitiethinhthuc>();
            Chitiethoadon = new HashSet<Chitiethoadon>();
            Chitietmausac = new HashSet<Chitietmausac>();
            Chitiettheloai = new HashSet<Chitiettheloai>();
        }
        [DisplayName("MÃ")]
        public string SpMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpTen { get; set; }
        [DisplayName("GIÁ")]
        public double SpGia { get; set; }
        [DisplayName("MÔ TẢ CHI TIẾT")]
        public string SpMotachitiet { get; set; }
        [DisplayName("GIỚI THIỆU")]
        public string SpGioithieu { get; set; }
        [DisplayName("HÌNH ẢNH")]
        public string HaMa { get; set; }

        public virtual Hinhanh Hinhanh { get; set; }
        public virtual ICollection<Chitietchude> Chitietchude { get; set; }
        public virtual ICollection<Chitiethinhthuc> Chitiethinhthuc { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual ICollection<Chitietmausac> Chitietmausac { get; set; }
        public virtual ICollection<Chitiettheloai> Chitiettheloai { get; set; }
    }
}
