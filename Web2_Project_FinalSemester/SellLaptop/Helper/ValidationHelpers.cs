using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace SellLaptop.Helper
{
    public class NgSinhAttribute:RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return (DateTime)value < DateTime.Now.AddYears(-1);
        }
    }

    public class AccessDKAttribute : ValidationAttribute
    {
        public bool Value { get; set; }

        public override bool IsValid(object value)
        {
            return value != null && value is bool && (bool)value == Value;
        }
    }

    public class UserLogAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var ent = new sellLaptopEntities();

            return (0 == ent.khach_hang.Where(a => a.tendn == value.ToString()).ToList().Count);
        }
    }

    public class ValidateFileAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            var file = value as HttpPostedFileBase;
            if (file == null)
            {
                return false;
            }
            
            try
            {
                using (var img = Image.FromStream(file.InputStream))
                {
                    return img.RawFormat.Equals(ImageFormat.Png) || img.RawFormat.Equals(ImageFormat.Jpeg) || img.RawFormat.Equals(ImageFormat.Gif);
                }
            }
            catch { }
            return false;
        }
    }
}