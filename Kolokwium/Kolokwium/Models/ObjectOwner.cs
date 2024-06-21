using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;


[Table("Object_Owner")]
[PrimaryKey(nameof(ObjectId), nameof(OwnerId))]
public class ObjectOwner
{
    public int ObjectId { get; set; }
    
    public int OwnerId { get; set; }
    
    [ForeignKey(nameof(ObjectId))]
    public Objects Object { get; set; } = null!;
    
    [ForeignKey(nameof(OwnerId))]
    public Owner Owner { get; set; } = null!;
    

}