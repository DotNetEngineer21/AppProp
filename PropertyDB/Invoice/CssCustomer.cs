using PropertyDB.Admin;
using PropertyDB.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Inventory
{
   public class CssCustomer
    {
        [Key]
        public int Code { get; set; }
        //Get all Info from Person
        public CssPerson Customer { get; set; }

        [Display(Name = "Categoria ")]
        public CssGeneral Category { get; set; }
        
        [Display(Name = "Limite Credito")]
        public decimal LineCredit { get; set; }
        
        [Display(Name = "Balance")]
        public decimal Balance { get; set; }

        [Display(Name = "Contacto")]
        [Column(TypeName = "varchar(100)")]
        public string NameContact { get; set; }
        
        [Display(Name = "Telefono")]
        [Column(TypeName = "varchar(15)")]
        public string PhoneContact { get; set; }
        
        [Display(Name = "Correo Electronico")]
        [Column(TypeName = "varchar(100)")]
        public string EmailContact { get; set; }
        
        // Group or Kind Customer 
        public CssGeneral Group { get; set; }
        // Vendor Outside
        public CssEmployee Vendor_Out { get; set; }
        // Vendor inside
        public CssEmployee Vendor_In { get; set; }

    }
}
