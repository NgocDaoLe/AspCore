using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public string HdMa { get; set; }
        public DateTime? HdNgaydat { get; set; }
        public DateTime HdNgyagiao { get; set; }
        public string HdDiachinguoinhan { get; set; }
        public string HdTennguoinhan { get; set; }
        public string HdSdtnguoinhan { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
