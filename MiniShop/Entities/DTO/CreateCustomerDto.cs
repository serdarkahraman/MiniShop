using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShop.Entities.DTO
{
    public class CreateCustomerDto
    {
        [Required(ErrorMessage = "FirstName name field is required.")]
        [MaxLength(25, ErrorMessage = "Maximum length for the FirstName field is {0}")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName name field is required.")]
        [MaxLength(25, ErrorMessage = "Maximum length for the LastName field is {0}")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Email field is required")]
        [EmailAddress(ErrorMessage = "The email provided is not a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Phone number field is required")]
        [Phone(ErrorMessage = "The phone number provided is not a valid phone number.")]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum Length for the address field is {0}")]
        public string Address { get; set; }
    }
}
