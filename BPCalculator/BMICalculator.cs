using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BPCalculator
{
    public class BMICalculator
    {
        [Range(10, 350, ErrorMessage = "Invalid Weight")]
        public float kg { get; set; }
        [Range(50 , 300, ErrorMessage = "Invalid Height")]
        public float  m { get; set; }
        public string bmiCalculate() 
        {
            float BMI = (kg/((m/100)*(m/100)));
 

            if (BMI < 18.5)
            { return("-> Underweight"); }
            if (BMI >= 18.5 && BMI <= 24.9)
            { return ("-> Normal"); }
            if (BMI >= 25)
            { return("-> Overweight"); }
            return ("Incorrect Values");
        }
        
    }
}
