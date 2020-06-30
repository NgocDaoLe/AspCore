using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }
        [DisplayName("MÃ")]
        public string HdMa { get; set; }
        [DisplayName("NGÀY ĐẶT")]
        public DateTime? HdNgaydat { get; set; }
        [DisplayName("NGÀY GIAO")]
        public DateTime HdNgyagiao { get; set; }
        [DisplayName("ĐỊA CHỈ")]
        public string HdDiachinguoinhan { get; set; }
        [DisplayName("NGƯỜI NHẬN")]
        public string HdTennguoinhan { get; set; }
        [DisplayName("SĐT")]
        public string HdSdtnguoinhan { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
