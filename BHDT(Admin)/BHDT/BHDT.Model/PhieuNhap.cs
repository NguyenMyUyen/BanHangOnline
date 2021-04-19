namespace BHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        public int MaPN { get; set; }

        public int? MaNCC { get; set; }

        public DateTime? NgayNhap { get; set; }

        public bool? DaXoa { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
