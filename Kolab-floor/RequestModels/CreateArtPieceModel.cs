using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolabFloor.RequestModels
{
    public class CreateArtPieceModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public IEnumerable<ArtData> ArtData { get; set; }

    }
}
