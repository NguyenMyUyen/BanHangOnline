namespace BHDT.Model
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
            BinhLuans = new HashSet<BinhLuan>();
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
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

        public int? SoLuongton { get; set; }

        public int? LuotXem { get; set; }

        public int? LuotBinhChon { get; set; }

        public int? SoLanMua { get; set; }

        public int? Moi { get; set; }

        public int? MaNCC { get; set; }

        public int? MaNSX { get; set; }

        public int? MaLoaiSP { get; set; }

        public bool? DaXoa { get; set; }

        public double? Sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }
    }
}
