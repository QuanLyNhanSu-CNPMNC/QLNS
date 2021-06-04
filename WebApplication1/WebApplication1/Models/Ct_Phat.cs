﻿//------------------------------------------------------------------------------
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

    public partial class Ct_Phat
    {
        [DisplayName("Mã chi tiết phạt")]
        public int MaCTPhat { get; set; }
        [DisplayName("Mã NV")]
        public int MaNhanVien { get; set; }
        [DisplayName("Mã loại phạt")]
        public int MaLoaiPhat { get; set; }
        [DisplayName("Trạng thái")]
        public bool TrangThai { get; set; }
        [DisplayName("Người sửa")]
        public string NguoiSua { get; set; }
        [DisplayName("Ngày sửa")]
        public System.DateTime NgaySua { get; set; }
        public bool IsChecked { get; set; }
        [DisplayName("Người phạt")]
        public string NguoiPhat { get; set; }
        [DisplayName("Ngày phạt")]
        public System.DateTime NgayPhat { get; set; }


        public virtual LoaiPhat LoaiPhat { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
