using Kolokwium.Models;

namespace Kolokwium.Services;

public interface IDbService
{
    public Task<ICollection<Owner>> GetObject(int ownerId);
    
    public Task<bool> DoesObjectExist(int id);

}