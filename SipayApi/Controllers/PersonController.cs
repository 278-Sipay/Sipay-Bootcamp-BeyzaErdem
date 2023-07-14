using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SipayApi.Model;
using SipayApi.ValidationRules;

namespace SipayApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    public PersonController() 
    { 
    
    }

    [HttpPost]
    public IActionResult Post([FromBody] Person person)
    {
        PersonValidator personValidator = new PersonValidator();
        var result = personValidator.Validate(person);

        if (result.IsValid)
        {
            return Ok(person);
        }
        return BadRequest(result.Errors);
    }
}
