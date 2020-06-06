using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Chitiettheloai = new HashSet<Chitiettheloai>();
        }

        [DisplayName("MÃ THỂ LOẠI")]
        public string TlMa { get; set; }
        [DisplayName("TÊN THỂ LOẠI")]
        public string TlTen { get; set; }

        public virtual ICollection<Chitiettheloai> Chitiettheloai { get; set; }
    }
}
