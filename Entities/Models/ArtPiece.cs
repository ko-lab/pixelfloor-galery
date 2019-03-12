using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities 
{
    public class ArtPiece
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public IEnumerable<ArtData> Data { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
