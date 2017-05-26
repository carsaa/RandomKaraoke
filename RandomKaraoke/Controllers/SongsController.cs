using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomKaraoke.Models;
using RandomKaraoke.Models.Entities;
using Microsoft.AspNetCore.Http;
using RandomKaraoke.Models.VM;

namespace RandomKaraoke.Controllers
{
    public class SongsController : Controller
    {
        SongDBContext context;

        public SongsController(SongDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //Vad är min IFormCollection egentligen?
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            //Sätter vymodellen till den vymodell vi får som resultat av RandomPlayer-metoden
            SongsIndexVM viewModel = DataManager.RandomPlayer(context);

            return View(viewModel);
        }

        public IActionResult List()
        {
            return View(context.ListSongs());
        }
    }
}
