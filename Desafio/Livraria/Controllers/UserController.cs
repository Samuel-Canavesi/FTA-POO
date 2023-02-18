using Microsoft.AspNetCore.Mvc;
using Livraria.Models;


namespace Livraria.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    [HttpGet(Name = "UserController")]
    public ActionResult<List<usermodel>> Getusers()
    {
        return Ok();
        {
        
        }
    }
}
