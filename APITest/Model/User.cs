using System.ComponentModel.DataAnnotations;

namespace APITest.Model
{
    public class User
    {
        [Required(ErrorMessage ="Required")]
        public string FillName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        [StringLength(10,MinimumLength =10,ErrorMessage ="10 digit only")]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage ="Please enter a valid number.example xxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
    }
}
