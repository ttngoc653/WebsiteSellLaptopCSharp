//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SellLaptop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class chi_tiet_don_hang
    {
        public int madh { get; set; }
        public int masp { get; set; }
        public int soluongsp { get; set; }
    
        public virtual don_hang don_hang { get; set; }
        public virtual san_pham san_pham { get; set; }
    }
}
