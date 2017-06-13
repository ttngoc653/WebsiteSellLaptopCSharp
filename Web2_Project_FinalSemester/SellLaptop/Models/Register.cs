using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SellLaptop.Helper;
using System.Web.Mvc;

namespace SellLaptop.Models
{
    public class Register
    {
        
        [Required(ErrorMessage ="HÃY NHẬP TÊN TÀI KHOẢN")]
        [UserLog(ErrorMessage ="TÀI KHOẢN BỊ TRÙNG. HÃY NHẬP TÊN TÀI KHOẢN KHÁC.")]
        [Remote("ValidationUser", "Default")]
        public string tendn { get; set; }

        [StringLength(64, MinimumLength = 6, ErrorMessage = "MẬT KHẨU KHÔNG ĐƯỢC DƯỚI 6 KÝ TỰ")]
        [Required(ErrorMessage = "HÃY NHẬP MẬT KHẨU")]
        public string mk { get; set; }

        [Required(ErrorMessage = "HÃY NHẬP LẠI MẬT KHẨU")]
        [System.ComponentModel.DataAnnotations.Compare("mk",ErrorMessage ="HAI MẬT KHẨU KHÔNG GIỐNG NHAU. HÃY NHẬP LẠI 2 MẬT KHẨU SAO CHO GIỐNG NHAU.")]
        public string mk1 { get; set; }

        [Required(ErrorMessage = "HÃY NHẬP HỌ TÊN CỦA QUÝ KHÁCH")]
        public string hoten { get; set; }
        
        [Required(ErrorMessage = "HÃY NHẬP NGÀY SINH CỦA QUÝ KHÁCH")]
        [NgSinh(ErrorMessage ="NGÀY SINH KHÔNG HỢP LỆ")]
        [Remote("ValidationNgSinh","Default")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ngsinh { get; set; }

        public bool gioitinh { get; set; }
                
        [Required(ErrorMessage = "HÃY NHẬP SỐ ĐIỆN THOẠI")]
        [RegularExpression("(\\+84|0)\\d{9,10}",ErrorMessage ="HÃY NHẬP ĐÚNG SỐ ĐIỆN THOẠI.")]
        public String sdt { get; set; }

        [Required(ErrorMessage = "HÃY NHẬP EMAIL")]
        [RegularExpression(@"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})",ErrorMessage ="EMAIL KHÔNG HỢP LỆ")]
        public string email { get; set; }
        /*
        [Required(ErrorMessage = "HÃY CHẤP NHẬN ĐIỀU KHOẢN.")]
        [AccessDK(Value =true,ErrorMessage ="HÃY CHẤP NHẬN ĐIỀU KHOẢN ĐI BẠN.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "The field Is Active must be checked.")]
        [Remote("ValidationDieuKhoan", "Default")]
        public Boolean chapnhandieukhoan { get; set; }
        */
        [Required(ErrorMessage ="HÃY THÊM ẢNH ĐẠI DIỆN.")]
        [ValidateFile(ErrorMessage = "HÃY THÊM ẢNH ĐẠI DIỆN CỦA QUÝ KHÁCH.")]
        public HttpPostedFileBase icon { get; set; }
    }
}