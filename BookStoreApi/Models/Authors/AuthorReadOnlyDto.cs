using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models.Authors
{
    public class AuthorReadOnlyDto:BaseDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Bio { get; set; }
    }
}
