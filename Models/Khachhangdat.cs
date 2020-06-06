using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Khachhangdat
    {
        public Khachhangdat()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }
        [DisplayName("MÃ")]
        public string KhMa { get; set; }
        [DisplayName("HỌ TÊN")]
        public string KhTen { get; set; }
        [DisplayName("SĐT")]
        public string KhSdt { get; set; }
        [DisplayName("EMAIL")]
        public string KhEmail { get; set; }
        [DisplayName("ĐỊA CHỈ")]
        public string KhDiachi { get; set; }
        [DisplayName("USERNAME")]
        public string KhUsername { get; set; }
        [DisplayName("PASSWORD")]
        public string KhPassword { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
