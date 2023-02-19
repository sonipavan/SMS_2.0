using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_OBJ.Login_
{
    public class ResultObject<T>
    {

        public ResultType Result;
        public string ResultMessage;
        public string Remark;
        public T ResultData;

    }
    public enum ResultType
    {
        Error, Success, Info, Warning, Attention
    }
}