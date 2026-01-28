using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPSAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace RPSAPI.Controllers;

//Tells ASP.NET this is an API controller
    [ApiController]
    //[controller] will be replaced with "RPSLS"
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        
//this field holds a reference to our service
//"readonly" means this field can only be assigned in the constructor and not modified elsewhere
private readonly RPSCpu _service;

//constructor runs when the controller is created
//ASP.NET will automatically injects IService here (dependency injection)

public RPSLSController(RPSCpu service)
{
    //store the injected service so we can use it in our endpoints
    _service = service;
}


//lets create our endpoint here
//Handles HTTP GET requests
//example: URL: GET /RPSLS/ComputerRnd

[HttpGet]

//Add "ComputerRnd" to the route
[Route("ComputerRnd")]

public string ComputerRndSelection()
    {
        //call the service method (function) to get the computer's random choice
        //The controller does NOT contain the game logic, it just calls our service
        return _service.GetCpuChoice();
    }
    

    }