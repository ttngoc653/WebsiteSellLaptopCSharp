using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellLaptop.Models
{
    public class LogIn
    {
        [Required(ErrorMessage = "Hãy nhập tên đăng nhập")]
        public String user { get; set; }

        [Required(ErrorMessage ="Hãy nhập mật khẩu")]
        public String pass { get; set; }

        public Boolean remember { get; set; }
    }
}