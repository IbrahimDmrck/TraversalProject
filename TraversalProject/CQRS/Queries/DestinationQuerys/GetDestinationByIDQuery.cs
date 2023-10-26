using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Queries.DestinationQuerys
{
    public class GetDestinationByIDQuery
    {

        public GetDestinationByIDQuery(int id)
        {
            this.id = id;
        }
        public int id { get; set; }
    }
}
