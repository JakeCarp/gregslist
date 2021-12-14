using gregslist.Models;
using gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }
        [HttpGet]
        public ActionResult<IEnumerable<House>> GetAllHouses()
        {
            try
            {
                List<House> houses = _hs.getAll();
                return Ok(houses);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<House> GetOne(string id)
        {
            try
            {
                House house = _hs.GetOne(id);
                return Ok(house);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                House house = _hs.Create(newHouse);
                return house;
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<House> Update([FromBody] House updatedHouse)
        {
            try
            {
                House house = _hs.Update(updatedHouse);
                return house;
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<String> Remove(string id)
        {
            try
            {
                string res = _hs.Remove(id);
                return Ok(res);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
