using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jensen_EHInterview.TODO
{
    public class TODOEndpoint
    {
        public TODOViewModel Get()
        {
            return new TODOViewModel();
        }

        public void Add(TODOViewModel model)
        {
            List<string> temp = (List<string>)HttpContext.Current.Session["TODOList"];
            string newTodo = model.Task;
            if (temp != null)
            {
                if (temp.Contains(newTodo))
                    newTodo = model.Task;
                else
                    temp.Add(model.Task);
                HttpContext.Current.Session.Add("TODOList", temp);
            }
            HttpContext.Current.Response.Redirect("../../");
        }
    }
}