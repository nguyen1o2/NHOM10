using System;
using System.Collections.Generic;

#nullable disable

namespace ONDE1.Models
{
    public partial class KhoaKham
    {
        public KhoaKham()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        public string Makhoa { get; set; }
        public string Tenkhoa { get; set; }

        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
