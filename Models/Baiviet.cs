using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Baiviet
    {
        [DisplayName("MÃ BÀI VIẾT")]
        public string BvMa { get; set; }
        [DisplayName("TÊN BÀI VIÊT")]
        public string BvTen { get; set; }
        [DisplayName("NỘI DUNG")]
        public string BvNoidung { get; set; }
    }
}
