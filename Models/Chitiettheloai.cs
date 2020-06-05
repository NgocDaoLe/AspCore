using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chitiettheloai
    {
        public string CttlMa { get; set; }
        public string TlMa { get; set; }
        public string SpMa { get; set; }

        public virtual Sanpham SpMaNavigation { get; set; }
        public virtual Theloai TlMaNavigation { get; set; }
    }
}
