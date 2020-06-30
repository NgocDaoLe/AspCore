using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace shophoatuoi.Models
{
    public partial class Chucvu
    {
        public Chucvu()
        {
            Nhansu = new HashSet<Nhansu>();
        }

        [DisplayName("MÃ")]
        public string CvMa { get; set; }
        [DisplayName("CHỨC VỤ")]
        public string CvTen { get; set; }
        [DisplayName("MÔ TẢ")]
        public string CvMotacongviec { get; set; }

        public virtual ICollection<Nhansu> Nhansu { get; set; }
    }
}
