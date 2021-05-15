namespace WebBHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_UuDai
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiUuDai { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiUuDai { get; set; }

        public double UuDai { get; set; }

        public virtual LoaiUuDai LoaiUuDai { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
