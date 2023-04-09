using BPC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BPC.Models;

namespace BPC.ViewComponents
{
    public class NewCategories : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
     
            return View();
        }
    }
}
