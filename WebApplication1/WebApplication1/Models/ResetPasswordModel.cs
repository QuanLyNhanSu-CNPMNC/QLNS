﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage ="Nhập mật khẩu mới", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string MatKhauMoi { get; set; }

        [Required(ErrorMessage = "Nhập xác nhận mật khẩu", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Compare("MatKhauMoi", ErrorMessage = "Xác nhận mật khẩu không khớp mật khẩu mới")]
        public string XacNhanMatKhau { get; set; }

        [Required]
        public string ResetCode { get; set; }

    }
}