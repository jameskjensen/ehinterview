using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jensen_EHInterview.TODO;

namespace Jensen_EHInterview.TODOEdit
{
    public class TODOEditEndpoint
    {
        public TODOViewModel Get(TODOViewModel input)
        {
            return input;
        }

        public void Edit(TODOInputModel input)
        {
            List<string> temp = (List<string>)HttpContext.Current.Session["TODOList"];
            if (!input.EditedTask.Equals(input.OriginalTask, StringComparison.CurrentCultureIgnoreCase))
            {
                temp[temp.IndexOf(input.OriginalTask)] = input.EditedTask;
                HttpContext.Current.Session["TODOList"] = temp;
            }
            HttpContext.Current.Response.Redirect("../../");
        }
    }
}