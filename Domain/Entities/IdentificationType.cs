using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class IdentificationType
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Description { get; set; }
    }
}
