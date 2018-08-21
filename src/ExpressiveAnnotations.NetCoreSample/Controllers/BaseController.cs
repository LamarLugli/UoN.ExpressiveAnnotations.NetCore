﻿using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;
using ExpressiveAnnotations.MvcWebSample.Misc;

namespace ExpressiveAnnotations.MvcWebSample.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var culture = CultureManager.Instance.Load(HttpContext);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = culture;

            var validation = ValidationManager.Instance.Load(HttpContext);
            ViewBag.Validation = validation;

            var indication = IndicationsManager.Instance.Load(HttpContext);
            ViewBag.Indication = indication;

            var triggers = TriggersManager.Instance.Load(HttpContext);
            ViewBag.Triggers = triggers;

            var verbose = VerbosityManager.Instance.Load(HttpContext);
            ViewBag.Verbose = verbose;
        }
    }
}
