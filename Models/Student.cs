using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementWithAuthen.Models
{
    public class Student
    {
        public int StudentID { get; set; } // primary key

        [Required]
        [StringLength(30)]
        public string StudentFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string StudentLastName { get; set; }

        [Required]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string StudentEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        
        public string StudentPhoneNumber { get; set; }

        public string StudentFullName
        {
            get { return StudentLastName + ", " + StudentFirstName; }
        }


        // navigation property
        public ICollection<RentedBook> RentedBooks { get; set; }
    }
}
