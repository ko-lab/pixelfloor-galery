using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Repository
{
    class ArtPieceRepository : RepositoryBase<ArtPiece>, IArtPieceRepository
    {
        public ArtPieceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<ArtPiece> FindAllWithData()
        {
            return RepositoryContext.ArtPieces.Include(data => data.Data);
        }
    }
}
