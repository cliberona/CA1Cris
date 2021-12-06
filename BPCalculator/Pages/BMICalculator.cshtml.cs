using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BPCalculator.Pages
{
    public class BMICalculatorModel : PageModel
    {

        [TempData]
        public string ResultInfo { get; set; }
        [BindProperty]
        public BMICalculator BMICal { get; set; }
        public void OnGet() 
        {
            BMICal = new BMICalculator { kg = 80, m = 180 };
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ResultInfo = BMICal.bmiCalculate();

            return RedirectToPage();
        }
    }
}
