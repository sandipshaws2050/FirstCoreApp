using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Components
{
    public class CommentViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(int id) 
        {
            List<string> comments = new List<string> { "Apps", "Core" };
            return View(comments);
            
        }
    }
}
