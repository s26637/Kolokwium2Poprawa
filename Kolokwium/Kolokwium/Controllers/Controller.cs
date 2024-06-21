using Kolokwium.DTOs;
using Kolokwium.Models;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;

[Route("api/owners")]
[ApiController]
public class Controller : ControllerBase
{
    private readonly IDbService _dbService;
    public Controller(IDbService dbService)
    {
        _dbService = dbService;
    }

    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharactersData(int id)
    {
        var objects = await _dbService.GetObject(id);
        
        
        
        return Ok(objects.Select(e => new GetOwnerDTO()
        {
            FirstName = e.FirstName,
            LastName = e.LastName,
            PhoneNumber = e.PhoneNumber,
            OwnerObject = e.ObjectOwners.Select(p => new ObjectDTO()
            {
                Id =  e.Id,
                Width = p.Object.Height,
                Height = p.Object.Width,
                Type = p.Object.ObjectType.Name,
                Warhouse = p.Object.Warehouse.Name

            }).ToList(),
            
        }));
    }
    
    [HttpPost("owners")]
    public async Task<IActionResult> AddItemToCharacter( PutDTO putDto)
    {
        
        var lista = new List<Objects>();
        
        foreach (var x in putDto.lista)
        {
            if (!await _dbService.DoesObjectExist(x))
            {
                return NotFound("Wrong object");
            }
            
            // lista.Add(new ObjectOwner()
            // {
            //     ObjectId = x,
            // });
        }

        
        return Ok();

    }
    
    
    
    
    
    
    
    
}