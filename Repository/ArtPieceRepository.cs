using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ArtDataRepository : RepositoryBase<ArtData>, IArtDataRepository
    {
        public ArtDataRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
