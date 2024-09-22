
using Microsoft.EntityFrameworkCore;
using TaxiManagment.Domia.Entities;


namespace TaxiManagment.Persistence.Context;

public class TaxiDBContext : DbContext
{
    public TaxiDBContext(DbContextOptions<TaxiDBContext> options)
         : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Rol> Rols { get; set; }
    public DbSet<Taxi> Taxis { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<TripDetail> TripDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }
    public DbSet<UserGroupDetail> UserGroupsDetails { get; set; }
    public DbSet<UserGroupRequest> UserGroupsRequests { get; set; }
    public DbSet<UserRol> UserRols { get; set; }

    public DbSet<Vehicle> Vehicles { get; set; } 


}
