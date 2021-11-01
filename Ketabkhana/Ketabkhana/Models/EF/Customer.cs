//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ketabkhana.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter First Name"), MaxLength(30), MinLength(2)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name"), MaxLength(30), MinLength(2)]
        public string lastName { get; set; }

        [Required, MaxLength(10)]
        public string gender { get; set; }

        [Required]
        public string dob { get; set; }

        [Required(ErrorMessage = "Please enter Email"), MaxLength(30)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter Username"), MaxLength(30), MinLength(4)]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter Password"), MaxLength(15), MinLength(4)]
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
