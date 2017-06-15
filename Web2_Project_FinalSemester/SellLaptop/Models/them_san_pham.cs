using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellLaptop.Models
{
    public class them_san_pham
    {

        [Required]
        public string tensp { get; set; }

        [Required]
        public string tenhangsx { get; set; }

        [Required]
        public int gia { get; set; }

        [Required]
        public string mau { get; set; }

        [Required]
        public HttpPostedFileBase icon { get; set; }

        [Required]
        public string loaicpu { get; set; }

        [Required]
        public int ramdl { get; set; }

        [Required]
        public string ramloai { get; set; }

        [Required]
        public int rambus { get; set; }

        [Required]
        public double kichthuocmh { get; set; }

        [Required]
        public int phangiaingang { get; set; }

        [Required]
        public int phangiaidoc { get; set; }

        [Required]
        public string cnmanhinh { get; set; }

        [Required]
        public bool camung { get; set; }

        [Required]
        public string ocung { get; set; }

        [Required]
        public int ocungdl { get; set; }

        [Required]
        public string ocung1 { get; set; }

        [Required]
        public int ocungdl1 { get; set; }

        [Required]
        public string tencartdohoa { get; set; }

        [Required]
        public string cnamthanh { get; set; }

        [Required]
        public string oquang { get; set; }

        [Required]
        public int sousb { get; set; }

        [Required]
        public bool hdmi { get; set; }

        [Required]
        public bool cartsd { get; set; }

        [Required]
        public string ketnoikhac { get; set; }

        [Required]
        public string chucnangkhac { get; set; }

        [Required]
        public string wifi { get; set; }

        [Required]
        public string lan { get; set; }

        [Required]
        public string btoothver { get; set; }

        [Required]
        public double camera { get; set; }

        [Required]
        public string pin { get; set; }

        [Required]
        public string hdh { get; set; }

        [Required]
        public double khoiluong { get; set; }

        [Required]
        public int dai { get; set; }

        [Required]
        public int rong { get; set; }

        [Required]
        public int day { get; set; }

        [Required]
        public string chatlieu { get; set; }

        [Required]
        public int slcon { get; set; }

        [Required]
        public HttpPostedFileBase anh1 { get; set; }

        [Required]
        public HttpPostedFileBase anh2 { get; set; }

        [Required]
        public HttpPostedFileBase anh3 { get; set; }

        [Required]
        public HttpPostedFileBase anh4 { get; set; }
    }
}