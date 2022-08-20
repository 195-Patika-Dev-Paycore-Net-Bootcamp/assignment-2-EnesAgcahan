using Microsoft.AspNetCore.Mvc;
using static EnesAgcahan_Hafta_2.Staff;


namespace EnesAgcahan_Hafta_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        // We create default staff
        public static List<Staff> staffs = new List<Staff>()
        {
            new Staff()
            {
                Id = 1,
                Name = "Deny",
                Lastname = "Sellen",
                DateOfBirth = new DateTime(1989, 01, 01),
                Email = "deny@gmail.com",
                PhoneNumber = 555443366,
                Salary = 4450,
            }
        };

        //Get staff section
        [HttpGet]
        [Route("getStaff")]

        public async Task<ActionResult<Staff>> getStaff()
        {
            return Ok(staffs);
        }
        //Get staff by id section
        [HttpGet]
        [Route("getStaffById")]

        public async Task<ActionResult<Staff>> getStaff(int id)
        {
            var staff = staffs.Find(x => x.Id == id);
            if (staff == null)
                return BadRequest("No Staffs found.");
            return Ok(staff);
            
        }
        //Post staff section
        [HttpPost]
        [Route("postStaff")]

        public async Task<ActionResult<Staff>> addStaff(int id, string name, string lastname, DateTime dateOfBirth, string email, int phoneNumber, int salary)
        
        {
             var staff = staffs.Find(x => x.Id == id);
             if (staff == null)
            {
                Staff staffAdded = new Staff();
                staffAdded.Id = id;
                staffAdded.Name = name;
                staffAdded.Lastname = lastname;
                staffAdded.DateOfBirth = dateOfBirth;
                staffAdded.Email = email;
                staffAdded.PhoneNumber = phoneNumber;
                staffAdded.Salary = salary;
                staffs.Add(staffAdded);
                return Ok(staffAdded);
            }
            else
            {
                return BadRequest("Staff has already.");
            }

        }
        //Put staff section
        [HttpPut]
        [Route("putStaff")]

        public async Task<ActionResult<Staff>> putStaff(int id, string name, string lastname, DateTime dateOfBirth, string email, int phoneNumber, int salary)
        {
            var staff = staffs.Find(x => x.Id == id);
            if (staff == null)
                return BadRequest("No Staffs found.");

            staff.Id = id;
            staff.Name = name;
            staff.Lastname = lastname;
            staff.DateOfBirth = dateOfBirth;
            staff.Email = email;
            staff.PhoneNumber = phoneNumber;
            staff.Salary = salary;
            //staffs.Add(staff);
            return Ok(staffs);

        }
        //Delete staff section
        [HttpDelete]
        [Route("deleteStaff")]

        public async Task<ActionResult<Staff>> deleteStaff(int id)
        {
            var staff = staffs.Find(x => x.Id == id);
            if (staff == null)
                return BadRequest("No Staffs found.");
            
            staffs.Remove(staff);
            return Ok(staffs);

        }




        

    }
}
