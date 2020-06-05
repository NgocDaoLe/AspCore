using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Chitiettheloai = new HashSet<Chitiettheloai>();
        }

        public string TlMa { get; set; }
        public string TlTen { get; set; }

        public virtual ICollection<Chitiettheloai> Chitiettheloai { get; set; }
    }
}
