//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenThuongHieu { get; set; }
        public Nullable<double> Sale { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> MALOAISP { get; set; }
        public string HinhAnh { get; set; }
    
        public virtual LOAISP LOAISP { get; set; }
    }
}
