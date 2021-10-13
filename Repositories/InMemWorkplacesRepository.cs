using System;
using System.Collections.Generic;
using System.Linq;
using qax.Entities;

namespace qax.Repositories
{
    public class InMemWorkplacesRepository
    {
        private readonly List<Workplace> workplaces = new()
        {
            new Workplace { Id = Guid.NewGuid(), Name = "pre assembly", CreatedDate = DateTimeOffset.UtcNow},
            new Workplace { Id = Guid.NewGuid(), Name = "filling", CreatedDate = DateTimeOffset.UtcNow},
            new Workplace { Id = Guid.NewGuid(), Name = "final assembly", CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<Workplace> GetWorkplaces()
        {
            return workplaces;
        }
        
        public Workplace GetWorkplace(Guid id)
        {
            //das hier ist aktuell noch schwarze Magie :) aus der hard gecodeten collection
            //per linq den treffer holen^^
            return workplaces.Where(workplace => workplace.Id == id).SingleOrDefault();
        }
    }
}