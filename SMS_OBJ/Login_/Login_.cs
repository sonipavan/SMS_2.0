using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS_OBJ.Login_
{
    public class Login_
    {

        public int Login_Id { get; set; }
        public int Login_Roll_Id { get; set; }

        //[Required(ErrorMessage = "Please enter User Nane")]
        public string Login_UserName { get; set; }

        //[Required(ErrorMessage = "Please enter Password")]
        public string User_Password { get; set; }

    }
}