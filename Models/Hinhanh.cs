using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Hinhanh
    {
        public Hinhanh()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string HaMa { get; set; }
        public string HaTen { get; set; }
        public string HaUrl { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
