using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using MediatR;
using Persistence;


namespace Application
{
    public class Details
    {
public class Query : IRequest<Activity>
{
    public Guid Id { get; set; }
}
        public class Handler : IRequestHandler<Query, Activity>
        {
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
               return await _context.Activities.FindAsync(request.Id);
            }
        }
    }
}