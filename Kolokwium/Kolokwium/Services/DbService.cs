using Kolokwium.Data;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }


    public async Task<ICollection<Owner>> GetObject(int id)
    {
        return await _context.Owners
            .Include(e => e.ObjectOwners)
            .ThenInclude(e => e.Object)
            .ThenInclude(e => e.ObjectType)
            .Include(e => e.ObjectOwners)
            .ThenInclude(e => e.Object)
            .ThenInclude(e => e.Warehouse)
            .Where(e => e.Id == id)
            .ToListAsync();

    }


    public async Task<bool> DoesObjectExist(int id)
    {
        return await _context.Objects.AnyAsync(e => e.Id == id);
    }


}