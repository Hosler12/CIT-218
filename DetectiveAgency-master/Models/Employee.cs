using System.ComponentModel.DataAnnotations;
    
namespace DetectiveAgency.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter your Id")]
        public int? Id { get; set; }
        [StringLength(30, ErrorMessage ="Name cannot be longer than 30 characters")]
        public string? Name { get; set; }
        [Required (ErrorMessage="Please enter your hours")]
        [Range(10, 75, ErrorMessage = "Hours must be between 10 and 75.")]
        public double? Hours { get; set; }
        [Required (ErrorMessage = "Please enter your rate")]
        [Range(15, 75, ErrorMessage = "Rate should be between $15 and $75")]
        public double? Rate { get; set; }
        public double? CalcSalary()
        {
            double? grosspay = 0;
            double? overtime = 0;
            double? regPay = 0;
            if (Hours > 40)
            {
                regPay = 40 * Rate;
                overtime = (Hours - 40) * Rate * 1.5;
            }
            else
            {
                regPay = Hours * Rate;
            }
            grosspay = regPay + overtime;
            return grosspay;
        }
    }
}
