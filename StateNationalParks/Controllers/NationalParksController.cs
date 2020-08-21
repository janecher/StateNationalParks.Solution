using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StateNationalParks.Models;
using Microsoft.EntityFrameworkCore;

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
    // GET - search by name - api/stateparks/?name=parkName
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get(string name)
    {
      var query = _db.NationalParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      return query.ToList();
    }

    // GET api/nationalparks/5
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
        return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }

    // POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark nationalPark)
    {
      _db.NationalParks.Add(nationalPark);
      _db.SaveChanges();
    }

    // PUT api/nationalparks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark nationalPark)
    {
        nationalPark.NationalParkId = id;
        _db.Entry(nationalPark).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/nationalparks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var nationalParkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
      _db.NationalParks.Remove(nationalParkToDelete);
      _db.SaveChanges();
    }
  }
}