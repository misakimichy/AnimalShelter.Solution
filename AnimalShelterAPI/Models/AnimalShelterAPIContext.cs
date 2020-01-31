using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AnimalShelterAPI.Models
{
    public class AnimalShelterAPIContext : DbContext
    {
        public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
            : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Carlo", Species = "Cat", Breed = "Domestic Loghair",  Age = 7, Gender = "Female" },
                new Animal { AnimalId = 2, Name = "Pepper", Species = "Dog",  Breed = "Pitbull", Age = 5, Gender = "Female" },
                new Animal { AnimalId = 3, Name = "Ivy", Species = "Cat", Breed = "Domestic Shorthair",  Age = 2, Gender = "Female" },
                new Animal { AnimalId = 4, Name = "Harry", Species = "Dog", Breed = "Chihuahua",  Age = 4, Gender = "Male" },
                new Animal { AnimalId = 5, Name = "Oreo", Species = "Dog", Breed = "Pitbull",  Age = 0, Gender = "Male" },
                new Animal { AnimalId = 6, Name = "Henry", Species = "Cat", Breed = "Domestic Longhair",  Age = 1, Gender = "Female" },
                new Animal { AnimalId = 7, Name = "Finny", Species = "Cat",  Breed = "Main Coon", Age = 3, Gender = "Female" },
                new Animal { AnimalId = 8, Name = "Salt", Species = "Cat", Breed = "Domestic Longhair",  Age = 4, Gender = "Female" },
                new Animal { AnimalId = 9, Name = "Hachi", Species = "Dog", Breed = "German Shepherd",  Age = 2, Gender = "Male" },
                new Animal { AnimalId = 10, Name = "Charlie", Species = "Cat", Breed = "Domestic Shorthair",  Age = 9, Gender = "Male" }
            );
        }

    }
}