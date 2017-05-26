using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomKaraoke.Models.VM //TODO varför .VM för hand och inte automatiskt?
{
    public class SongsListVM
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Disc { get; set; }
    }
}
