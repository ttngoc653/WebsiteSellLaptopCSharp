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
    
    public partial class hang_sx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hang_sx()
        {
            this.cpus = new HashSet<cpu>();
            this.san_pham = new HashSet<san_pham>();
        }
    
        public string tenhangsx { get; set; }
        public string truso { get; set; }
        public string mota { get; set; }
        public int an { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cpu> cpus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<san_pham> san_pham { get; set; }
    }
}
