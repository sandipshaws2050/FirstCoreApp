using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Attributes
{
    public class ValidateCheckbox : ValidationAttribute , IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-ValidateCheckbox", "Please accept terms and conditions");
        }

        public override bool IsValid(object value)
        {

            if ((bool)value == true)
                return true;
            else
                return false;
                       
           
        }
    }
}
