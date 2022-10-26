using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnMyOwn.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Name")]
        [Column("Name")]
        [StringLength(30, ErrorMessage = "Please only use the first 30 characters of your name. You may need to remove middle names and/or end portions of your last name if you continue seeing this error.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name = "Phone Number")]
        [Column("Phone Number")]
        [RegularExpression(@"\d\d\d-\d\d\d-\d\d\d\d", ErrorMessage = "Your phone number should be entered in this pattern: 123-456-7890")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the city you live in")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state you live in")]
        [StringLength(2,ErrorMessage = "Please use the 2 character shorthand for your state.")]
        public string State { get; set; }

        [Required (ErrorMessage = "Please choose a phone")]
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
