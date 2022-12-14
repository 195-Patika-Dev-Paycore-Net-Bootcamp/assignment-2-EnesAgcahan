using System.ComponentModel.DataAnnotations;


namespace EnesAgcahan_Hafta_2
{
    public class Staff
    {
        public int Id { get; set; }

        [MinLength(4), MaxLength(200), RegularExpression(@"^[a-zA-Z0-9!@#\$%\^\&*\)\(+=._-]+$", ErrorMessage = "Invalid username")]
        public string Name { get; set; }

        [MinLength(4), MaxLength(200), RegularExpression(@"^[a-zA-Z0-9!@#\$%\^\&*\)\(+=._-]+$", ErrorMessage = "Invalid username")]
        public string Lastname { get; set; }

        [Range(typeof(DateTime), minimum: "1945-11-11", maximum: " 2002-10-10",
            ErrorMessage = "Valid dates for the Property {0} between {1} and {2}")]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9!@#\$%\^\&*\)\(+=_-]+$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Phone is not valid.")]
        [RegularExpression(@"^(\+[0-9]{9})$")]
        public int PhoneNumber { get; set; }

        [Range(minimum: 2000, maximum: 9000)]
        public int Salary { get; set; }

        

       public Staff()
        {

            
        }
    }
}
