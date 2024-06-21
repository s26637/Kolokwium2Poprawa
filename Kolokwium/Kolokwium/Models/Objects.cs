
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models;


[Table("Object")]
public class Objects
{
    [Key]
    public int Id { get; set; }
    
    public int WarehouseId { get; set; }
    
    public int ObjectTypeId { get; set; }
    
    public int Width { get; set; }
    
    public int Height { get; set; }

    [ForeignKey(nameof(WarehouseId))] public Warehouse Warehouse { get; set; } = null!;
    
    [ForeignKey(nameof(ObjectTypeId))]
    public ObjectType ObjectType { get; set; }  = null!;
    
    public ICollection<ObjectOwner> ObjectOwners { get; set; } = new List<ObjectOwner>();


}