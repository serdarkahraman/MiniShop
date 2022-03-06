using System.ComponentModel.DataAnnotations;
namespace MiniShop.Entities
{
    public class Customer
    {
        public Customer() => Created = DateTime.Now;

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public string FullName { get => $"{FirstName} {LastName}"; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        [Required]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string CustomerType { get; set; }

        public DateTime Created { get; set; }
    }
}
