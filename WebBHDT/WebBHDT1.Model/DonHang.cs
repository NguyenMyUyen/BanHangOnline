namespace WebBHDT1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            CT_DonHang = new HashSet<CT_DonHang>();
        }

        [Key]
        public int MaDDH { get; set; }

        public DateTime? NgayDat { get; set; }

        public bool? TinhTrangGiaoHang { get; set; }

        public DateTime? NgayGiao { get; set; }

        public int? MaKH { get; set; }

        public double? TongTien { get; set; }

        public bool? TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonHang> CT_DonHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
