using Microsoft.AspNetCore.Mvc;
using gregslist.Models;
using gregslist.DB;
using gregslist.Services;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        //Used to extabish CRUD Methods
        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            try
            {
                List<Car> cars = _cs.GetAll();
                return Ok(cars);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetOne(string id)
        {
            try
            {
                Car car = _cs.GetOne(id);
                return car;
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        //req.body is now [FromBody]
        public ActionResult<Car> Create([FromBody] Car newCar)
        {
            try
            {
                Car car = _cs.Create(newCar);
                return car;
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Car> Update([FromBody] Car updatedCar)
        {
            try
            {
                Car car = _cs.Update(updatedCar);
                return car;
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<String> Remove(String id)
        {
            try
            {
                string res = _cs.Remove(id);
                return Ok(res);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }
}
1