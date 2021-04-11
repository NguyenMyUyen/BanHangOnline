namespace WebBanHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETKMs = new HashSet<CHITIETKM>();
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }

        [StringLength(10)]
        public string MaThuongHieu { get; set; }

        [StringLength(50)]
        public string TenThuongHieu { get; set; }

        public int? SoLUong { get; set; }

        [StringLength(10)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(1)]
        public string HinhAnh { get; set; }

        public int KichThuoc { get; set; }

        public DateTime NgaySanXuat { get; set; }

        [Required]
        [StringLength(50)]
        public string CPU { get; set; }

        [Required]
        [StringLength(50)]
        public string RAM { get; set; }

        [Required]
        [StringLength(50)]
        public string HeDieuHanh { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string MoTa { get; set; }

        [Required]
        [StringLength(50)]
        public string Mau { get; set; }

        public double? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETKM> CHITIETKMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        public virtual LOAI LOAI { get; set; }

        public virtual THUONGHIEU THUONGHIEU { get; set; }
    }
}
