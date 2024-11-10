using Application;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")] //Add the route for the controller
    [ApiController] //Ensure the controller behaves as an API controller
    public class ActivitiesController : BaseApiController
    {

//Get: api/activities
 [HttpGet] //api/activities
   public async Task<ActionResult<List<Activity>>>GetActivities()
   {
    return await Mediator.Send(new List.Query());
   }
   //Get: api/activities/{id}
   [HttpGet("{id}")] //api/activities/hdfkjg
   public async Task<ActionResult<Activity>> GetActivity(Guid id)
   {
    return await Mediator.Send(new Details.Query{Id = id});
   }
    }
}