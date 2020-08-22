using System.Collections.Generic;
using StateNationalParks.Models;

namespace StateNationalParks.Dtos
{
  public class UserDto
  {
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}