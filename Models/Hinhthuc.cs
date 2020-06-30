using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Hinhthuc
    {
        public Hinhthuc()
        {
            Chitiethinhthuc = new HashSet<Chitiethinhthuc>();
        }
        [DisplayName("MÃ HÌNH THỨC")]
        public string HtMa { get; set; }
        [DisplayName("HÌNH THỨC")]
        public string HtTen { get; set; }

        public virtual ICollection<Chitiethinhthuc> Chitiethinhthuc { get; set; }
    }
}
