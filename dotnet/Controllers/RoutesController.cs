using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace service.Controllers
{
    public class RoutesController : Controller
    {
        public string LucisHandler()
        {
            return "{\"Name\": \"Lucis\", \"CanImportADotNetJSONDependency\": false}";
        }

    }
}
