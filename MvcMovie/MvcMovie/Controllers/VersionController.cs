using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class VersionController : Controller
    {
        public string Index()
        {
            // typeof(Controller).Assembly.GetName().Version.ToString()
            string version = typeof(Controller).Assembly.GetName();
            version += version.Version.ToString();
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }
    }
}