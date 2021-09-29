using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    public class ArticleController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
