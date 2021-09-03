using PropertyDB.Admin;
using PropertyDB.Inventory;
using PropertyDB.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Invoice
{
    public class CssInvoice
    {
        [Key]
        public int Code { get; set; }
        [Display(Name = "Oficina")]
        public CssCompany Office { get; set; }

        [Display(Name = "Fecha ")]
        public DateTime InvoiceDate { get; set; }

        [Display(Name = "Total")]
        public decimal InvoiceTotal { get; set; }

        [Display(Name = "Descuento")]
        public decimal Descuent { get; set; }

        [Display(Name = "ITBIS")]
        public decimal Itbis { get; set; }

        [Display(Name = "Tipo de Pago ")]
        public CssGeneral PayKind { get; set; }

        [Display(Name = "Cliente ")]
        public CssCustomer CustomerID { get; set; }

        [Display(Name = "Condición")]
        public CssGeneral Condition { get; set; } // Credit-8,15, 30days / Cash

        [Display(Name = "Balance")]
        public decimal Balance { get; set; }

        [Display(Name = "Empleado")]
        public CssEmployee EmployeeID { get; set; }

        [Display(Name = "Comprobante")]
        public String TaxReceipt { get; set; }

        public DateTime Create { get; set; }
    }        
}
