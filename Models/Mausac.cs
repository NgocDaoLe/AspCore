using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Chitietmausac = new HashSet<Chitietmausac>();
        }

        public string MsMa { get; set; }
        public string MsTen { get; set; }

        public virtual ICollection<Chitietmausac> Chitietmausac { get; set; }
    }
}
