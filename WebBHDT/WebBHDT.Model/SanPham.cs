namespace WebBHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CT_DonHang = new HashSet<CT_DonHang>();
            CT_UuDai = new HashSet<CT_UuDai>();
        }

        [Key]
        public int MaSP { get; set; }

        [StringLength(225)]
        public string TenSP { get; set; }

        public decimal? DonGia { get; set; }

        public DateTime? NgayCapNhap { get; set; }

        public string CauHinh { get; set; }

        public string Mota { get; set; }

        public string HinhAnh { get; set; }

        public int? Moi { get; set; }

        public int? MaNSX { get; set; }

        public int? MaLoaiSP { get; set; }

        public bool? DaXoa { get; set; }

        public double? UuDai { get; set; }

        public string HinhAnh1 { get; set; }

        public string HinhAnh2 { get; set; }

        public string HinhAnh3 { get; set; }

        public string HinhAnh4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonHang> CT_DonHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_UuDai> CT_UuDai { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }
    }
}
