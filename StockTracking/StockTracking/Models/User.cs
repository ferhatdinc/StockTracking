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

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ProductRegisters = new HashSet<ProductRegister>();
            this.Products = new HashSet<Product>();
        }
    
        [DisplayName("Kullan�c� ID")]
        public int UserID { get; set; }
        [DisplayName("Kullan�c� Ad�")]
        public string UserName { get; set; }
        [DisplayName("Kullan�c� Soyad�")]
        public string UserSurname { get; set; }
        [DisplayName("Rol ID")]
        public Nullable<int> RoleID { get; set; }
        [DisplayName("Departman ID")]
        public Nullable<int> DepartmentID { get; set; }
        [DisplayName("Kullan�c� Aktif Mi?")]
        public Nullable<bool> UserIsActive { get; set; }
        [DisplayName("�ifre")]
        public string UserPassword { get; set; }
    
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRegister> ProductRegisters { get; set; }
        public virtual UserRole UserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
