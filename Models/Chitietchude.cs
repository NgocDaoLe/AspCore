using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chitietchude
    {
        public string CtcdMa { get; set; }
        public string CdMa { get; set; }
        public string SpMa { get; set; }

        public virtual Chude CdMaNavigation { get; set; }
        public virtual Sanpham SpMaNavigation { get; set; }
    }
}
