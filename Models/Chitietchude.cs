using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Chitietchude
    {
        [DisplayName("MÃ")]
        public string CtcdMa { get; set; }
        [DisplayName("CHỦ ĐỀ")]
        public string CdMa { get; set; }
        [DisplayName("SẢN PHẨM")]
        public string SpMa { get; set; }

        public virtual Chude CdMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
