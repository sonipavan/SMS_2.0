using SMS_DA.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_OBJ.Login_;

namespace SMS_MGR.Login
{
    public class Login_Mgr :ILogin_Mgr
    {
        private readonly ILogin_DA Login_DA;
        public Login_Mgr(ILogin_DA login_DA)
        {
            this.Login_DA = login_DA;
        }

        Login_ ResultObject = new Login_();
        public Login_ GetLogin(string username, string password)
        {
            Login_ data = Login_DA.Login(username, password);
           
            return data;
            
        }
    }
}
