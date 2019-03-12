using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class ArtData
    {
        [Key]
        public int Id { get; set; }
        public int X { get; set; }
        public int ArtPieceId { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
    }
}
