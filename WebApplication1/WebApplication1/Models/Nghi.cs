//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nghi
    {
        public int MaNhanVien { get; set; }
        public System.DateTime NgayNghi { get; set; }
        public Nullable<bool> Phep { get; set; }
        public string NguoiDuyet { get; set; }
        public string GhiChu { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}