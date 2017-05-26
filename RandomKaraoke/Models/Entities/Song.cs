using System;
using System.Collections.Generic;

namespace RandomKaraoke.Models.Entities
{
    public partial class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Disc { get; set; }
    }
}
