using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Chitiethinhthuc
    {
        [DisplayName("MÃ")]
        public string CthtMa { get; set; }
        [DisplayName("HÌNH THỨC")]
        public string HtMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpMa { get; set; }

        public virtual Hinhthuc HtMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
