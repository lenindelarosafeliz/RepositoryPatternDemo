using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return ($"{FirstName} {LastName}");

            }
        }
        public DateTime BirthDate { get; set; }
    }
}
