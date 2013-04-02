using System.Web.Routing;
using Bottles;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

// You can remove the reference to WebActivator by calling the Start() method from your Global.asax Application_Start
[assembly: WebActivator.PreApplicationStartMethod(typeof(Jensen_EHInterview.App_Start.AppStartFubuMVC), "Start", callAfterGlobalAppStart: true)]

namespace Jensen_EHInterview.App_Start
{
    public static class AppStartFubuMVC
    {
        public static void Start()
        {
            FubuApplication.BootstrapApplication<MyApplication>();
        }
    }
}