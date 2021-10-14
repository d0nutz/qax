using System;
using System.Collections.Generic;
using qax.Entities;

namespace  qax
{
        public interface IWorkplacesRepository
    {
        Workplace GetWorkplace(Guid id);
        IEnumerable<Workplace> GetWorkplaces();
    }
}