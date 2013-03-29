using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace MVCDemo.Models
{
    public class DebugDataView<TEntity> : IView where TEntity : Domain.Model.TEntity
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            Write(writer, "--Routing Data --");
            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writer, "key:{0},value:{1}", key, viewContext.RouteData.Values[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }

    public class DebugViewEngine<TEntity> : IViewEngine where TEntity : Domain.Model.TEntity
    {
        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName,
            string masterName, bool useCache)
        {            
            if (viewName == "DebugData")
            {
                return new ViewEngineResult(new DebugDataView<TEntity>(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "Debug data View engine" });
            }
        }

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "Debug Data View Engine" });
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {

        }
    }
}