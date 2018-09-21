using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
  [Authorize]
  [Route("test")]
  public class TestController
  {
    [HttpGet]
    public string Hello()
    {
      return "Hello";
    }
  }
}
