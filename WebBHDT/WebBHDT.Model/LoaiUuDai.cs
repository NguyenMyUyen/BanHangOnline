namespace WebBHDT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiUuDai")]
    public partial class LoaiUuDai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiUuDai()
        {
            CT_UuDai = new HashSet<CT_UuDai>();
        }

        [Key]
        public int MaLoaiUuDai { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiUuDai { get; set; }

        public double? UuDai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_UuDai> CT_UuDai { get; set; }
    }
}
