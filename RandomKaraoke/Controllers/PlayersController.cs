using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomKaraoke.Models;
using static RandomKaraoke.Models.DataManager;
using RandomKaraoke.Models.VM;

namespace RandomKaraoke.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            ViewBag.Players = GetAllPlayers();
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PlayersCreateVM viewModel)
        {
            CreatePlayer(viewModel);
            return RedirectToAction(nameof(List));
        }

    }
}
