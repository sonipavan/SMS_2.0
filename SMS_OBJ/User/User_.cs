using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMS_OBJ.User
{
    public class User_
    {
        [Display(Name = "User Id")]
        public int User_Id { get; set; }

        [Display(Name = "User Name")]
        public string User_Name { get; set;}

        [Display(Name = "User Mobile")]
        public string User_Mobile { get; set;}

        [Display(Name = "User Email")]
        public string User_Email { get; set;}

        [Display(Name = "User Address")]
        public string User_Address { get; set;}
        

    }
}
