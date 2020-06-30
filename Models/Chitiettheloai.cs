using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Chitiettheloai
    {
        [DisplayName("MÃ")]
        public string CttlMa { get; set; }
        [DisplayName("THỂ LOẠI")]
        public string TlMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpMa { get; set; }

        public virtual Sanpham SpMaNavigation { get; set; }
        public virtual Theloai TlMaNavigation { get; set; }
    }
}
