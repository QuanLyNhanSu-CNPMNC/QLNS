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

    public partial class Nghi
    {
        [DisplayName("Mã nhân viên")]
        public int MaNhanVien { get; set; }
        [DisplayName("Ngày nghỉ")]
        public System.DateTime NgayNghi { get; set; }
        [DisplayName("Phép")]
        public bool Phep { get; set; }
        [DisplayName("Người duyệt")]
        public string NguoiDuyet { get; set; }
        [DisplayName("Ngày sửa")]
        public Nullable<System.DateTime> NgaySua { get; set; }
        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }

        public bool IsChecked { get; set; }


        public virtual NhanVien NhanVien { get; set; }
    }
}
