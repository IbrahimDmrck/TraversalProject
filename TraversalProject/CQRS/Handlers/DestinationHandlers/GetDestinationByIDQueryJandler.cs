using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Queries.DestinationQuerys;
using TraversalProject.CQRS.Results.DestinationResults;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryJandler
    {

        private readonly Context _context;

        public GetDestinationByIDQueryJandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight
            };
        }
    }
}
