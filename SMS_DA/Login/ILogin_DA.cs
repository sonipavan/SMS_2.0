using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_OBJ.Login_;

namespace SMS_DA.Login
{
    public interface ILogin_DA
    {

        //ResultObject<Login_> ResultObject1 = new ResultObject<Login_>();
        List<Login_> Login(string username, string password);
    }
}
