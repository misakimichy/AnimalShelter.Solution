using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace AnimalShelterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterAPIContext _db;
        public AnimalsController(AnimalShelterAPIContext db)
        {
            _db = db;
        }
    
        // GET api/Animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string species, string breed, int age, string gender)
        {
            var query = _db.Animals.AsQueryable();

            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }
            if (breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }
            if (age != 0)
            {
                query = query.Where(entry => entry.Age == age);
            }
            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }
            return query.ToList();
        }

        // GET api/Animals/id
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
        }

        // POST api/Animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        // PUT api/Animals/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/Animals/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }
    }
}
