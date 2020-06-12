using System;
using System.Collections.Generic;

namespace shophoatuoi.Models
{
    public partial class Nhansu
    {
        public string NsMa { get; set; }
        public string CvMa { get; set; }
        public string NsHoten { get; set; }
        public int NsNamsinh { get; set; }
        public string NsCmnd { get; set; }
        public string NsSdt { get; set; }
        public string NsDiachi { get; set; }
        public string NsUsername { get; set; }
        public string NsPassword { get; set; }

        public virtual Chucvu Chucvu { get; set; }
    }
}
