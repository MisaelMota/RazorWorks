using RazorPage.Models;
using System.Collections.Generic;

namespace RazorPage.Data
{
    public interface IAnimesControl
    {
        IEnumerable<Animes> GetAnimes();

        Animes AnimesPorID(int AId);

        public void CreateAnime(Animes animes);

        public void UpdateAnimes(Animes animes);

        public void DeleteAnimes(Animes animes);
    }
}