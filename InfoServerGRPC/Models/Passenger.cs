using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoServerGRPC.Models
{
    [Table("Passenger", Schema = "dbo")]
    public class Passenger
    {
        [Key]
        public Guid AccountId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountNum { get; set; }

        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
    }
}
