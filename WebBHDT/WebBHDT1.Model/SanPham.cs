namespace WebBHDT1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CT_DonHang = new HashSet<CT_DonHang>();
        }

        [Key]
        public int MaSP { get; set; }

        [StringLength(225)]
        public string TenSP { get; set; }

        public decimal? DonGia { get; set; }

        public DateTime? NgayCapNhap { get; set; }

        public string Mota { get; set; }

        public string HinhAnh { get; set; }

        public int? MaNSX { get; set; }

        public int? MaLoaiSP { get; set; }

        public bool? DaXoa { get; set; }

        public string HinhAnh1 { get; set; }

        public string HinhAnh2 { get; set; }

        public string HinhAnh3 { get; set; }

        public string HinhAnh4 { get; set; }

        public int? SoLuong { get; set; }

        public bool? Tinhtrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonHang> CT_DonHang { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
