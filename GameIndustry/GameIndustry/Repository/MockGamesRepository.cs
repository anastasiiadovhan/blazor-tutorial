using System;
using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<Game> _games;

        public MockGamesRepository()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)
                },
                new Game()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015, 5, 18)
                },
                new Game()
                {
                    Name = "GTA 5",
                    Genre = "Action",
                    ReleaseDate = new DateTime(2015, 4, 5)
                }
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}

