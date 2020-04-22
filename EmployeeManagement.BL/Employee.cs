using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.BL
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public int Phone { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; }

        public string Designation { get; set; }

       [DisplayName("Full Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
