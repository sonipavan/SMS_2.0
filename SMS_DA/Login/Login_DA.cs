using SMS_OBJ.Login_;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Reflection;

namespace SMS_DA.Login
{
    public class Login_DA : ILogin_DA
    {
       
        string cs = ConfigurationManager.ConnectionStrings["SMS_Database"].ToString();
        public Login_ Login(string username, string password)
        {
            ResultObject<Login_> resultObject = new ResultObject<Login_>();
            List<Login_> logins =new List<Login_>() ;
            Database db = new SqlDatabase(cs);
            Login_ login = new Login_();
           
            using (DbCommand dbCommand = db.GetStoredProcCommand("SMS_USP_Login"))
            {
                try
                {
                    db.AddInParameter(dbCommand, "@UserName", DbType.String, username);
                    db.AddInParameter(dbCommand, "@Password", DbType.String, password);
                    db.AddInParameter(dbCommand, "@RequestType", DbType.String, "Login");
                    DataSet data = db.ExecuteDataSet(dbCommand);

                    for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                    {
                        login.Flag = data.Tables[0].Rows[i]["Flag"].ToString();
                        
                    }
                    if(login.Flag == "True")
                    {
                        for (int i = 0; i < data.Tables[1].Rows.Count; i++)
                        {
                            
                            login.Login_Id = Convert.ToInt32(data.Tables[1].Rows[i]["Login_Id"]);
                            login.Login_Roll_Id = Convert.ToInt32(data.Tables[1].Rows[i]["Login_Roll_Id"]);
                            login.Login_UserName = data.Tables[1].Rows[i]["Login_UserName"].ToString();
                            login.Role_Name = data.Tables[1].Rows[i]["Role_Name"].ToString();
                            //logins.Add(login);

                        }
                    }

                    //logins = ConvertTo<Login_>(data);
                    //for (int i = 0; i < data.Rows.Count; i++)
                    //{
                    //    Login_ login = new Login_();
                    //    login.Login_Id= Convert.ToInt32(data.Rows[i]["Login_Id"]);
                    //    login.Login_Roll_Id = Convert.ToInt32(data.Rows[i]["Login_Roll_Id"]);
                    //    login.Login_UserName = data.Rows[i]["Login_UserName"].ToString();
                    //    login.Role_Name = data.Rows[i]["Role_Name"].ToString();
                    //    logins.Add(login);

                    //}

                    //resultObject.ResultData = logins;
                    //return logins;
                    return login;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            //resultObject.Result = logins;
            
        }
        //#region Database Method    
        //public List<T> ConvertTo<T>(DataTable datatable) where T : new()
        //{
        //    List<T> Temp = new List<T>();
        //    try
        //    {
        //        List<string> columnsNames = new List<string>();
        //        foreach (DataColumn DataColumn in datatable.Columns)
        //            columnsNames.Add(DataColumn.ColumnName);
        //        Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
        //        return Temp;
        //    }
        //    catch
        //    {
        //        return Temp;
        //    }
        //}
        //public T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        //{
        //    T obj = new T();
        //    try
        //    {
        //        string columnname = "";
        //        string value = "";
        //        PropertyInfo[] Properties;
        //        Properties = typeof(T).GetProperties();
        //        foreach (PropertyInfo objProperty in Properties)
        //        {
        //            columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
        //            if (!string.IsNullOrEmpty(columnname))
        //            {
        //                value = row[columnname].ToString();
        //                if (!string.IsNullOrEmpty(value))
        //                {
        //                    if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
        //                    {
        //                        value = row[columnname].ToString().Replace("$", "").Replace(",", "");
        //                        objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
        //                    }
        //                    else
        //                    {
        //                        value = row[columnname].ToString();
        //                        objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
        //                    }
        //                }
        //            }
        //        }
        //        return obj;
        //    }
        //    catch (Exception ex)
        //    {
        //        return obj;
        //    }
        //}
        //#endregion
    }
}
