using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMS_OBJ.Student
{
    public class Student_
    {
        [Display(Name ="Student Id")]
        public int Stu_Id { get; set; }

        [Display(Name = "Student Name")]
        public string Stu_Name { get; set; }

        [Display(Name = "Student Mobile")]
        public string Stu_Mobile { get; set; }

        [Display(Name = "Student Address")]
        public string Stu_Add { get; set; }

        [Display(Name = "Student Email")]
        public string Stu_Email { get; set; }

        [Display(Name = "Student Password")]
        public string Stu_Pass { get; set; }
    }
}
