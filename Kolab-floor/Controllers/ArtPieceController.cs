using Contracts;
using Entities;
using KolabFloor.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolabFloor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtPieceController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public ArtPieceController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<ArtPiece> GetPieces()
        {
            return _repoWrapper.ArtPiece.FindAllWithData();
        }
        
        [HttpPost]
        public IActionResult CreateArtPiece([FromBody] CreateArtPieceModel artPieceModel)
        {

                ArtPiece artPiece = new ArtPiece()
                {
                    Data = artPieceModel.Data,
                    CreatedAt = DateTime.UtcNow.Date,
                    Title = artPieceModel.Title,
                    Artist = artPieceModel.Artist
                };
                _repoWrapper.ArtPiece.Create(artPiece);
                _repoWrapper.ArtPiece.Save();
                return Created("GetPieces",artPiece);
        }
    }
}
