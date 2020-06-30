using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Chitietmausac
    {
        [DisplayName("MÃ")]
        public string CtmsMa { get; set; }
        [DisplayName("MÀU SẮC")]
        public string MsMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpMa { get; set; }

        public virtual Mausac MsMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
