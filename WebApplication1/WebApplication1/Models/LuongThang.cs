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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class LuongThang
    {
        public int MaLuong_Thang { get; set; }
        public System.DateTime ThangNam { get; set; }
        public int TongGioLamViec { get; set; }
        public int TongGioTangCa { get; set; }
        public int TongThuong { get; set; }
        public int TongPhat { get; set; }
        public int MaLuongCoBan { get; set; }
    
        public virtual LuongCoBan LuongCoBan { get; set; }
    }
}
