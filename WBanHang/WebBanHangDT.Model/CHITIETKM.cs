namespace WebBanHangDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETKM")]
    public partial class CHITIETKM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaKhuyenMai { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        public int? PHANTRAMKM { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
