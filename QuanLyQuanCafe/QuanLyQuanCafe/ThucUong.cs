//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanCafe
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThucUong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucUong()
        {
            this.DonHang = new HashSet<DonHang>();
        }
    
        public string MaThucUong { get; set; }
        public string MaLoai { get; set; }
        public string TenThucUong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<bool> KhaDung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHang { get; set; }
        public virtual LoaiNuoc LoaiNuoc { get; set; }
    }
}
