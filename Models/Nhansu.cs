using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shophoatuoi.Models
{
    public partial class Nhansu
    {
        [DisplayName("MÃ NHÂN SỰ")]
        public string NsMa { get; set; }
        [DisplayName("CHỨC VỤ")]
        public string CvMa { get; set; }

        [DisplayName("HỌ TÊN")]
        public string NsHoten { get; set; }
        [DisplayName("NĂM SINH")]
        public int NsNamsinh { get; set; }
        [DisplayName("CMND")]
        public string NsCmnd { get; set; }
        [DisplayName("SỐ ĐIỆN THOẠI")]
        public string NsSdt { get; set; }
        [DisplayName("ĐỊA CHỈ")]
        public string NsDiachi { get; set; }
        [DisplayName("TÀI KHOẢN")]
        public string NsUsername { get; set; }
        [DisplayName("MẬT KHẨU")]
        public string NsPassword { get; set; }

        public virtual Chucvu Chucvu { get; set; }
    }
}
