using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")] //Add the route for the controller
    [ApiController] //Ensure the controller behaves as an API controller
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
public ActivitiesController(DataContext context)
{
    _context = context;
}
//Get: api/activities
 [HttpGet] //api/activities
   public async Task<ActionResult<List<Activity>>>GetActivities()
   {
    return await _context.Activities.ToListAsync();
   }
   //Get: api/activities/{id}
   [HttpGet("{id}")] //api/activities/hdfkjg
   public async Task<ActionResult<Activity>> GetActivity(Guid id)
   {
    return await _context.Activities.FindAsync(id);
   }
    }
}