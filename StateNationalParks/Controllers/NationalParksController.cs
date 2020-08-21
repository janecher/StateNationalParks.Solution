using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StateNationalParks.Models;

namespace StateNationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private StateNationalParksContext _db;

    public NationalParksController(StateNationalParksContext db)
    {
      _db = db;
    }

    // GET api/nationalparks
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get()
    {
      return _db.NationalParks.ToList();
    }

    // GET api/nationalparks/5
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
        return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }

    // POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark animal)
    {
      _db.NationalParks.Add(animal);
      _db.SaveChanges();
    }
  }
}