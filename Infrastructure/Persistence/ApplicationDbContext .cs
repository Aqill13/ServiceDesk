using Domain.Features.Organization.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceDesk.Domain.Features.Identity.Entities;

namespace ServiceDesk.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Team> Teams => Set<Team>();

    public DbSet<DepartmentMembership> DepartmentMemberships => Set<DepartmentMembership>();

    public DbSet<TeamMembership> TeamMemberships => Set<TeamMembership>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}