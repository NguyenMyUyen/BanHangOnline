namespace WebBanHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [Key]
        [StringLength(10)]
        public string SoHoaDon { get; set; }

        [StringLength(10)]
        public string MaSanPham { get; set; }

        [StringLength(10)]
        public string MaKhachHang { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        public int? ThanhTien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDatHang { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayGiaoHang { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
