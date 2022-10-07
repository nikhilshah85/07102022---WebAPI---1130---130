using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace greetingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [HttpGet]
        [Route("greetings")]
        public IActionResult Greetuser()
        {
            //process the method, do data operations with Model file 
            //return HTTPStatus Code
            return Ok("Hello and Welcome to WebAPI - Day 1 training");
        }

        [HttpGet]
        [Route("greetings/guestName")]
        public IActionResult GreetUser(string guestName)
        {
            return Ok("Welcome to api  " + guestName);
        }
        [HttpGet]
        [Route("add/num1/num2")]
        public IActionResult Calculate(int num1, int num2)
        {
            if (num1 < num2)
            {
                return Ok("First Number has to be greater than 2nd No");
            }
            if (num1 == 0 || num2 == 0)
            {
                return Ok("Please pass numbers greater than 0");
            }
            return Ok(num1 + num2);

        }

    }
}




