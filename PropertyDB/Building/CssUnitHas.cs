using PropertyDB.Admin;
using PropertyDB.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB.Building
{
    /// <summary>
    ///   List of Item containing a unit and them status (Normal/Maintenance/broken)
    /// </summary>
    public class CssUnitHas
    {
        [Key]
        public int Code { get; set; }
        
        // List of Item containing a unit
        public List<CssItem> UnitHas { get; set; }

        // status(Normal/Maintenance/broken)
        [Display(Name = "Estatus")]
        public CssGeneral Status { get; set; }


    }
}
