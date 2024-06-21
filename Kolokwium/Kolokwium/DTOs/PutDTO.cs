using System.ComponentModel.DataAnnotations;

namespace Kolokwium.DTOs;

public class PutDTO
{

    [Required] public string FirstName { get; set; }
    
    [Required] public string LastName { get; set; }
    
    [Required] public string PhoneNumber { get; set; }
    
    public List<int> lista { get; set;} = new List<int>();


    
}