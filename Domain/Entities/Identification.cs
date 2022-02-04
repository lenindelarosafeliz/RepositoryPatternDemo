using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Identification
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int IdentificationTypeId { get; set; }

        [Column (TypeName ="nvarchar(10)")]
        public string Number { get; set; }
        public Person Person { get; set; }
        public IdentificationType IdentificationType { get; set; }
    }
}
