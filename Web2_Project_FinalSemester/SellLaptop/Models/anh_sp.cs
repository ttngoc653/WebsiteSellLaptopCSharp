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
    
    public partial class anh_sp
    {
        public int masp { get; set; }
        public string tenfile { get; set; }
    
        public virtual san_pham san_pham { get; set; }
    }
}
