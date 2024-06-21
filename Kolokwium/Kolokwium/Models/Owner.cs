using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models;

[Table("Owner")]
public class Owner
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    
    [MaxLength(9)]
    public string PhoneNumber { get; set; } = string.Empty;
    
    public ICollection<ObjectOwner> ObjectOwners { get; set; } = new List<ObjectOwner>();


}