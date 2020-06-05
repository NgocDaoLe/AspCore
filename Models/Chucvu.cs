using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Chucvu
    {
        public Chucvu()
        {
            Nhansu = new HashSet<Nhansu>();
        }

        public string CvMa { get; set; }
        public string CvTen { get; set; }
        public string CvMotacongviec { get; set; }

        public virtual ICollection<Nhansu> Nhansu { get; set; }
    }
}
