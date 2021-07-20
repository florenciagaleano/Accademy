using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Filters
{
    public class MyActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            string mensaje = string.Format("OnActionExecuting - El nombre del controlador es {0}, el nombre de la accion es {1}", controller, action); ;

            Debug.WriteLine(mensaje, "Action filterss values");
        }


        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            string mensaje = string.Format("OnActionExecuted - El nombre del controlador es {0}, el nombre de la accion es {1}", controller, action); ;

            Debug.WriteLine(mensaje, "Action filterss values");
        }
    }
}