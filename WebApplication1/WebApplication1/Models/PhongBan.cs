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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class PhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongBan()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }

        [DisplayName("Mã phòng ban")]
        public int MaPB { get; set; }
        [DisplayName("Tên phòng ban")]
        [Required(ErrorMessage = "Tên phòng ban không được trống...")]
        public string TenPB { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được trống...")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại bắt đầu là 0 và không bao gồm chữ.")]
        public string SoDT { get; set; }

        public bool IsChecked { get; set; }
        [DisplayName("Người sửa")]
        public string NguoiSua { get; set; }

        [DisplayName("Ngày sửa")]
        public System.DateTime NgaySua { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
