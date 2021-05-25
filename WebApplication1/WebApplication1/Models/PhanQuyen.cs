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
    public partial class PhanQuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanQuyen()
        {
            this.TaiKhoans = new HashSet<TaiKhoan>();
        }

        [DisplayName("Mã quyền")]
        public int MaQuyen { get; set; }
        [DisplayName("Tên quyền")]
        [Required(ErrorMessage = "Tên quyền không được trống...")]
        public string TenQuyen { get; set; }
        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }

        public bool IsChecked { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
