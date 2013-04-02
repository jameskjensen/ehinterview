using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jensen_EHInterview.TODO;

namespace Jensen_EHInterview.TODODelete
{
    public class TODODeleteEndpoint
    {
        public TODOViewModel Get(TODOViewModel input)
        {
            return input;
        }

        public void Delete(TODOViewModel input)
        {
            List<string> temp = (List<string>)HttpContext.Current.Session["TODOList"];
            temp.Remove(input.Task);
            HttpContext.Current.Session["TODOList"] = temp;
            HttpContext.Current.Response.Redirect("../../");
        }
    }
}