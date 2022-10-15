using System.ComponentModel.DataAnnotations;

namespace OnMyOwn.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"\d\d\d-\d\d\d-\d\d\d\d", ErrorMessage = "Your phone number should be entered in this pattern: 123-456-7890")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the city you live in")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state you live in")]
        public string State { get; set; }

        [Required (ErrorMessage = "Please choose a phone")]
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
