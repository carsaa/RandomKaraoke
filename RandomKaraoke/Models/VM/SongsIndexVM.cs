using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomKaraoke.Models.VM
{
    public class SongsIndexVM
    {
        public string FirstPlayer { get; set; }
        public string SecondPlayer { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Disc { get; set; } //För att välja skiva

        //Från Björn
        //public IEnumerable<SelectListItem> Owner { get; set; }
        //public string SelectedDisc { get; set; }
    }
}
