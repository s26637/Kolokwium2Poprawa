namespace Kolokwium.DTOs;

public class GetOwnerDTO
{
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<ObjectDTO> OwnerObject { get; set; } = new List<ObjectDTO>();
        
       

}

public class ObjectDTO
{
        public int Id { get; set; }
        
        
        public int Width { get; set; }
        
        public int Height { get; set; }
    
        public string Type { get; set; }
       
        public string Warhouse { get; set; }

}
