using RandomKaraoke.Models.Entities;
using RandomKaraoke.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomKaraoke.Models
{
    //Bra med statiskt lista som man gör add på
    //Kommer existera så länge vi inte stänger applikationen
    public static class DataManager
    {
        private static List<Player> players = new List<Player>
        {
            new Player {Name = "Carolina"},
            new Player {Name = "Julia"},
            new Player {Name = "Arietta"},
            new Player {Name = "Daniel"}
        };

        public static Player[] GetAllPlayers()
        {
            return players.ToArray();
        }

        //public static void CreatePlayer(Player player)
        //{
        //    players.Add(player);
        //}

        //public static void CreatePlayer(PlayersCreateVM viewModel)
        public static void CreatePlayer(PlayersCreateVM viewModel)
        {
            players.Add(
                new Models.Player
                {
                    Name = viewModel.Name
                });
        }

        //Spara spelarna i en session genom en stringarray och ta bort DataManager?

        public static SongsIndexVM RandomPlayer(SongDBContext context)
        {
            //Slumpar fram en siffra och väljer spelare på det indexet
            Random random = new Random();
            int randomIndx = random.Next(0, players.Count);
            Player firstPlayer = players[randomIndx];
            int randomIndx2 = random.Next(0, players.Count);

            do
            {
                randomIndx2 = random.Next(0, players.Count);
            }
            while (randomIndx == randomIndx2);

            Player secondPlayer = players[randomIndx2];

            SongsIndexVM viewModel = new SongsIndexVM();

            //Lägg till skiva här? Beroende på vad som valts i vyn.. 
            //Hämtar låt från Song som sorterats på GUID (alltså slumpmässigt) och valt första träffen
            var rndmSong = context.Song
                .OrderBy(s => Guid.NewGuid())
                .Select(s => new { Artist = s.Artist, Title = s.Title })
                .First();

            //Sätter vymodellens properties till de framslumpade resultaten
            viewModel.FirstPlayer = firstPlayer.Name;
            viewModel.SecondPlayer = secondPlayer.Name;
            viewModel.Artist = rndmSong.Artist;
            viewModel.Title = rndmSong.Title;

            return viewModel;
        }

    }
}
