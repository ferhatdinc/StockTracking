//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTracking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class ProductRegister
    {
        [DisplayName("Zimmet ID")]
        public int RegisterID { get; set; }
        [DisplayName("Kullan�c� ID")]
        public Nullable<int> UserID { get; set; }
        [DisplayName("�r�n ID")]
        public Nullable<int> ProductID { get; set; }
        [DisplayName("Zimmetlenen �r�n Say�s�")]
        public Nullable<int> Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
