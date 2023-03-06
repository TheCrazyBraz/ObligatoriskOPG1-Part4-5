using Microsoft.AspNetCore.Mvc;
using ObligatoriskOPG1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObligatoriskOPG1_Part4_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private Repository repository = new Repository();
        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return repository.getAllCars();
        }


        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return repository.GetCarById(id);
        }

        // POST api/<CarsController>
        [HttpPost]
        public Car Post([FromBody] Car car)
        {
            return repository.AddCar(car);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public Car Put(int id, [FromBody] Car car)
        {
            return repository.UpdateCar(id, car);
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public Car Delete(int id)
        {
            return repository.DeleteCar(id);
        }
    }
}
