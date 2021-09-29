using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstCoreApp.Controllers
{
    public class AccountController : Controller
    {

       
        public IActionResult SignUpUser()
        {

            BindDropDown();

            return View();
        }
       
        [HttpPost]
        public IActionResult SignUpUser(SignUpUserModel model)
        {
            if (ModelState.IsValid)
            {
               
                if (Convert.ToInt32(model.City.ToString()) == 0)
                {

                    ModelState.AddModelError("", "Please Select City");
                }
                else {

                    //TODO

                }

            }


            BindDropDown();

            return View();
        }

        #region SelectListItem
        private void BindDropDown() {

            List<SelectListItem> cities = new()
            {
                new SelectListItem { Value = "1", Text = "Kolkata" },
                new SelectListItem { Value = "2", Text = "Asansol" },
                new SelectListItem { Value = "4", Text = "Bardhamn" },
                new SelectListItem { Value = "5", Text = "Durgapur" },
                new SelectListItem { Value = "6", Text = "Kankinara" },
                new SelectListItem { Value = "7", Text = "Naihati" }
               
            };

            //assigning SelectListItem to view Bag
            cities.Insert(0, (new SelectListItem { Text = "Select City", Value = "0" }));
            ViewBag.cities = cities;


           


        }
        #endregion
    }
}
