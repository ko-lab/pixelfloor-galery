using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IArtDataRepository _artData;
        private IArtPieceRepository _artPiece;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
            repositoryContext.Database.EnsureCreated();
        }

        public IArtPieceRepository ArtPiece {
            get {
                if (_artPiece == null)
                {
                    _artPiece = new ArtPieceRepository(_repoContext);
                }
                return _artPiece;
            }
        }
        public IArtDataRepository ArtData
        {
            get
            {
                if (_artData == null)
                {
                    _artData = new ArtDataRepository(_repoContext);
                }
                return _artData;
            }
        }
    }
}
