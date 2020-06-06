using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Chitietmausac = new HashSet<Chitietmausac>();
        }
        [DisplayName("MÃ MÀU SẮC")]
        public string MsMa { get; set; }
        [DisplayName("TÊN MÀU SẮC")]
        public string MsTen { get; set; }

        public virtual ICollection<Chitietmausac> Chitietmausac { get; set; }
    }
}
