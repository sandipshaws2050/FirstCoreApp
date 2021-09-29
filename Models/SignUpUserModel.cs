using FirstCoreApp.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        [RegularExpression(pattern: "^Mr\\..*|^Mrs\\..*|^Ms\\..*|^Miss\\..*", ErrorMessage = "Name must start with Mr./Mrs./Ms./Miss.")]
        [Display(Name ="Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Username")]
        [StringLength(maximumLength: 20, MinimumLength = 6, ErrorMessage = "Length must be between 10 to 25")]
        [Display(Name = "Username")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Please enter a strong Password")]
        [Display(Name = "Password")]
        [StringLength(maximumLength: 15, MinimumLength = 6, ErrorMessage = "Length must be between 10 to 25")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm Password does not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter contact no")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Please enter 10 digit Valid contact No")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        [Display(Name="Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Select Country")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Select City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [ValidateCheckbox(ErrorMessage ="Please accept terms and conditions")]
        public bool terms { get; set; }
    }
}
