namespace WebBHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        public int MATK { get; set; }

        [StringLength(20)]
        public string TENDN { get; set; }

        [StringLength(32)]
        public string MATKHAU { get; set; }

        public DateTime? NGAYDANGKY { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? MaKH { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
