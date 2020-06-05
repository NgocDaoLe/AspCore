using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chude
    {
        public Chude()
        {
            Chitietchude = new HashSet<Chitietchude>();
        }

        public string CdMa { get; set; }
        public string CdTen { get; set; }

        public virtual ICollection<Chitietchude> Chitietchude { get; set; }
    }
}
