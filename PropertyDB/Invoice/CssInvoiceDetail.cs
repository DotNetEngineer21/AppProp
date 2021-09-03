using PropertyDB.Admin;
using PropertyDB.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PropertyDB.Invoice
{
    public class CssInvoiceDetail
    {

        [Key]
        public int Code { get; set; }
        
        public CssCompany Company { get; set; }
        [Display(Name = "# Factura")]
        public CssInvoice InvoiceID { get; set; }

        [Display(Name = "Producto")]
        public CssItem ProductID { get; set; }
        [Display(Name = "Cantidad ")]
        public decimal Quantity { get; set; }
        [Display(Name = "Precio ")]
        public decimal Price { get; set; }
        [Display(Name = "Costo ")]
        public decimal Cost { get; set; }
        [Display(Name = "Descuento")]
        public decimal Descuent { get; set; }
        [Display(Name = "Total")]
        public decimal NetPrice { get; set; }
        [Display(Name = "Lote")]
        [Column (TypeName ="Varchar(30)")]
        public string LoteId { get; set; }
        [Display(Name = "Prociento de Venta")]
        public decimal PorcentSold { get; set; }
        
        [Display(Name = "Factor Unidad")]
        public decimal UndFactor { get; set; }
        
    }
}
