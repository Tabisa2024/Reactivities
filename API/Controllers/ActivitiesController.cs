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
   [HttpPost]
   public async Task<IActionResult> CreateActivity(Activity activity)
   {
            await Mediator.Send(new Create.Command { Activity = activity });
            return Ok();

   }
     [HttpPut("{id}")]
      public async Task<ActionResult>EditActivity(Guid id, Activity activity)
      {
        activity.Id= id;

        await Mediator.Send(new Edit.Command{Activity = activity});
        return Ok();
      }
       
       [HttpDelete("{id}")]
       public async Task<IActionResult> DeleteActivity (Guid id) 
       {
        await Mediator.Send(new Delete.Command{Id = id});
         return Ok();
       }
    }
}