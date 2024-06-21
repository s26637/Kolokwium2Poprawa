using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Object = System.Object;

namespace Kolokwium.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Objects> Objects { get; set; }
    public DbSet<ObjectOwner> ObjectOwners { get; set; }
    public DbSet<ObjectType> ObjectTypes { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Objects>().HasData(new List<Objects>
        {
            new Objects()
            {
                Id = 1,
                WarehouseId = 1,
                ObjectTypeId = 1,
                Width = 5,
                Height = 4
                
            }
            
        });
        
        modelBuilder.Entity<ObjectOwner>().HasData(new List<ObjectOwner>
        {
            new ObjectOwner()
            {
               ObjectId = 1,
               OwnerId = 1
            }
            
        });
                
        modelBuilder.Entity<ObjectType>().HasData(new List<ObjectType>
        {
            new ObjectType()
            {
                Id = 1,
                Name = "object1"
            },
            new ObjectType()
            {
                Id = 2,
                Name = "object2"
            },
            new ObjectType()
            {
                Id = 3,
                Name = "object3"
            },
            new ObjectType()
            {
                Id = 4,
                Name = "object4"
            }
            
        });
        
        
        modelBuilder.Entity<Owner>().HasData(new List<Owner>
        {
            new Owner()
            {
                Id = 1,
                FirstName = "Marek",
                LastName = "Adamski",
                PhoneNumber = "777333111"
                
            },
            new Owner()
            {
                Id = 2,
                FirstName = "Aleksandra",
                LastName = "Wiśniewska",
                PhoneNumber = "999111444"
                
            },
            new Owner()
            {
                Id = 3,
                FirstName = "Jan",
                LastName = "Kowalski",
                PhoneNumber = "555333111"
                
            },
            
            
        });
        
        
        modelBuilder.Entity<Warehouse>().HasData(new List<Warehouse>
        {
            new Warehouse()
            {
               Id = 1,
               Name = "war1"
            },
            new Warehouse()
            {
                Id = 2,
                Name = "war2"
            }
            
        });

        
        

    }
}