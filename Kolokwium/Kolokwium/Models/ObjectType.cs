using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models;


[Table("Object_Type")]
public class ObjectType
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    
    public ICollection<Objects> Objects { get; set; } = new List<Objects>();

}