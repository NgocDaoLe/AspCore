using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chitietmausac
    {
        public string CtmsMa { get; set; }
        public string MsMa { get; set; }
        public string SpMa { get; set; }

        public virtual Mausac MsMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
