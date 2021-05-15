namespace WebBHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DonHang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        [StringLength(225)]
        public string TenSP { get; set; }

        public double? UuDai { get; set; }

        public int? SoLuong { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
