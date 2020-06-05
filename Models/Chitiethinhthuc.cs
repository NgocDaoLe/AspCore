using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chitiethinhthuc
    {
        public string CthtMa { get; set; }
        public string HtMa { get; set; }
        public string SpMa { get; set; }

        public virtual Hinhthuc HtMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
