using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StateNationalParks.Models;
using Microsoft.EntityFrameworkCore;

namespace StateNationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateParksController : ControllerBase
  {
    private StateNationalParksContext _db;

    public StateParksController(StateNationalParksContext db)
    {
      _db = db;
    }

    // GET api/stateparks
    // GET - search by name - api/stateparks/?name=parkName
    /// <summary>
    /// Retrieve all state parks, or search by name.
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get(string name)
    {
      var query = _db.StateParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      return query.ToList();
    }

    // GET api/stateparks/5
    /// <summary>
    /// Retreives a state park by id.
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<StatePark> Get(int id)
    {
        return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
    }

    // POST api/stateparks
    /// <summary>
    /// Add state park to the database.
    /// </summary>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /NationalPark
    ///     {
    ///        "name": "Deception Pass State Park",
    ///        "address": "Washington 98277"
    ///     }
    ///
    /// </remarks>
    [HttpPost]
    public void Post([FromBody] StatePark statePark)
    {
      _db.StateParks.Add(statePark);
      _db.SaveChanges();
    }

    // PUT api/stateparks/5
    /// <summary>
    /// Update a state park by id.
    /// </summary>
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark statePark)
    {
        statePark.StateParkId = id;
        _db.Entry(statePark).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // DELETE api/stateparks/5
    /// <summary>
    /// Removes a state park from the database by id.
    /// </summary>
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateParkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
      _db.StateParks.Remove(stateParkToDelete);
      _db.SaveChanges();
    }
  }
}