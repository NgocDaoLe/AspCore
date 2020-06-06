using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace shophoatuoi.Models
{
    public partial class Chude
    {
        public Chude()
        {
            Chitietchude = new HashSet<Chitietchude>();
        }

        [DisplayName("MÃ CHỦ ĐỀ")]
        public string CdMa { get; set; }
        [DisplayName("TÊN CHỦ ĐỀ")]
        public string CdTen { get; set; }
        
        public virtual ICollection<Chitietchude> Chitietchude { get; set; }
    }
}
