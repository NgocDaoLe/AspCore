using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Hinhanh
    {
        public Hinhanh()
        {
            Sanpham = new HashSet<Sanpham>();
        }
        [DisplayName("MÃ HÌNH ẢNH")]
        public string HaMa { get; set; }
        [DisplayName("HÌNH ẢNH")]
        public string HaTen { get; set; }
        [DisplayName("HÌNH ẢNH")]
        public string HaUrl { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
