using SMS_OBJ.Login_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMS_MGR.Login
{
    public interface ILogin_Mgr
    {
        List<Login_> GetLogin(string username, string password);   
    }
}
