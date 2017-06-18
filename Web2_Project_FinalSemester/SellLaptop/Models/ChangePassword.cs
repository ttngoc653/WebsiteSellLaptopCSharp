using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellLaptop.Models
{
    public class ChangePassword
    {
        [Display(Name ="NHẬP MẬT KHẨU CŨ:")]
        [Required(ErrorMessage ="MỜI NHẬP MẬT KHẨU CŨ")]
        public String passOld { get; set; }

        [Display(Name ="NHẬP MẬT KHẨU MỚI:")]
        [Required(ErrorMessage = "HÃY NHẬP MẬT KHẨU MỚI")]
        //[Range(8, 100, ErrorMessage = "MẬT KHẨU PHẢI TỪ 8 KÝ TỰ TRỢ LÊN")]
        [StringLength(100,MinimumLength =8,ErrorMessage = "MẬT KHẨU PHẢI TỪ 8 KÝ TỰ TRỢ LÊN")]
        public String passNew { get; set; }

        [Display(Name ="NHẬP LẠI MẬT KHẨU MỚI:")]
        [Required(ErrorMessage = "HÃY NHẬP LẠI MẬT KHẨU MỚI")]
        [System.ComponentModel.DataAnnotations.Compare("passNew", ErrorMessage = "HAI MẬT KHẨU MỚI KHÔNG GIỐNG NHAU. HÃY NHẬP LẠI MẬT KHẨU MỚI SAO CHO GIỐNG NHAU")]
        public String rePassNew { get; set; }
    }
}