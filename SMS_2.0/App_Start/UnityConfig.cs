//using SMS_DA.DashBoard_DA;
using SMS_DA.Login;
//using SMS_MGR.DashBoard_Mgr;
using SMS_MGR.Login;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;


namespace SMS_2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<IDashboard_DA, Dashboard_DA>();
            //container.RegisterType<IDashboard_Mgr, Dashboard_Mgr>();
            container.RegisterType<ILogin_DA, Login_DA>();
            container.RegisterType<ILogin_Mgr, Login_Mgr>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}