using Hospital.Api.Models.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{
	}
	public DbSet<Patient> Patients = Set<Patient>();
	public DbSet<Gender> Genders = Set<Gender>();
	public DbSet<Document_type> Documents_type = Set<Document_type>();


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entit
		
	}
}