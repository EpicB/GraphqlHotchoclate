using System.ComponentModel.DataAnnotations;

namespace Graphql.models
{
    public class platform{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Licencekey { get; set; }
    }
}