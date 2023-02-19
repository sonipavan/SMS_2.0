using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMS_OBJ.School
{
    public class School_
    {

        [Display(Name = "School Id")]
        public int Sch_Id { get; set; }

        [Display(Name = "School Name")]
        public string Sch_Name { get; set; }

        [Display(Name = "School Type")]
        public string Sch_Type { get; set; }

        [Display(Name = "School Description")]
        public string Sch_Des { get; set; }

        [Display(Name = "School Email")]
        public string Sch_Email { get; set; }

        [Display(Name = "School Address")]
        public string Sch_Add { get; set; }
    }
}
