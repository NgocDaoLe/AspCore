using System;
using System.Collections.Generic;

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

        public string SpMa { get; set; }
        public string SpTen { get; set; }
        public double SpGia { get; set; }
        public string SpMotachitiet { get; set; }
        public string SpGioithieu { get; set; }
        public string HaMa { get; set; }

        public virtual Hinhanh HaMaNavigation { get; set; }
        public virtual ICollection<Chitietchude> Chitietchude { get; set; }
        public virtual ICollection<Chitiethinhthuc> Chitiethinhthuc { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual ICollection<Chitietmausac> Chitietmausac { get; set; }
        public virtual ICollection<Chitiettheloai> Chitiettheloai { get; set; }
    }
}
