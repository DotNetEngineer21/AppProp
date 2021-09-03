using PropertyDB.Admin;
using PropertyDB.Building;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyDB
{
    public class CssPerson
    {

        [Key]
        public int Code { get; set; }
        [Display(Name = "Nombre(s)")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido(s)")]
        public string LastName{ get; set; }
        
        public CssAddress Address { get; set; }

        // Person's phone kind (home/cell/work) list
        public IEnumerable<CssPhone> Phone { get; set; }

        // Person's email list
        public IEnumerable<CssEmail> Email { get; set; }

        // Person's socialnetwork list
        public IEnumerable<CssGeneral> SocialNetwork { get; set; }

        // Person's picture
        public CssPicture Pic { get; set; }

    }
}
