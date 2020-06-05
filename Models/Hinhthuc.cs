using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Hinhthuc
    {
        public Hinhthuc()
        {
            Chitiethinhthuc = new HashSet<Chitiethinhthuc>();
        }

        public string HtMa { get; set; }
        public string HtTen { get; set; }

        public virtual ICollection<Chitiethinhthuc> Chitiethinhthuc { get; set; }
    }
}
