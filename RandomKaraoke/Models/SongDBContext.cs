using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandomKaraoke.Models.VM;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RandomKaraoke.Models.Entities
{
    public partial class SongDBContext : DbContext
    {
        //Hämtar alla låtar från databasen Song och returnerar dem i en array
        public SongsListVM[] ListSongs()
        {
            return Song
                .Select(s => new SongsListVM
                {
                    Title = s.Title,
                    Artist = s.Artist,
                    Disc = s.Disc,
                })
                .ToArray();
        }

        //Från Björn
        //public IEnumerable<SelectListItem> ConvertToSelectItem()
        //{
        //    return Owner.Select(o => new SelectListItem
        //    {
        //        Text = o.Name,
        //        Value = o.Id.ToString(),
        //    });
        //}
    }
}

