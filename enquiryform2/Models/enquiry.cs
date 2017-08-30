using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace enquiryform2.Models
{
    public class enquiry
    {
        public int id { get; set; }
        [Required(ErrorMessage = " name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Emailid is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = " ContactNo is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = " Comments required.")]
        public string Comments { get; set; }
    }
}