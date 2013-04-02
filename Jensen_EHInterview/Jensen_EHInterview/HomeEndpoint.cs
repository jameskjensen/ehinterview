using System.Web.Routing;
using System.Collections.Generic;
using Bottles;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using System;
using System.Web;
using Jensen_EHInterview.TODO;

namespace Jensen_EHInterview
{
	public class HomeModel
	{
		public string Message { get; set; }
        public string Task { get; set; }

        public List<string> TODOList { get; set; }
	}
	
	// Fubu's default policies look for classes suffixed with "Endpoint" or "Endpoints"
    public class HomeEndpoint
	{
		// Fubu will use HomeEndpoint.Index as the default "home" route
		public HomeModel Index()
		{
            HomeModel hm = new HomeModel();
            List<string> temp = (List<string>)HttpContext.Current.Session["TODOList"];
            if (temp != null)
                hm.TODOList = temp;
            else
            {
                hm.TODOList = new List<string> { "Grocery Shopping", "Wash Car", "Pay Mortgage" };
                HttpContext.Current.Session.Add("TODOList", hm.TODOList);
            }
            return hm;
		}
	}
}