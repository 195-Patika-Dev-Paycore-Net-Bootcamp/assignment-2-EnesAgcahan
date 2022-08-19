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

        [Range(typeof(DateTime), " 11/11/1945", "10/10/2002",
            ErrorMessage = "Valid dates for the Property {0} between {1} and {2}")]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9!@#\$%\^\&*\)\(+=_-]+$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Phone( ErrorMessage = "Phone is not valid.")]
        public int PhoneNumber { get; set; }

        [MinLength(2000),MaxLength(9000)]
        public int Salary { get; set; }



        

        public Staff()
        {

        }
    }
}
