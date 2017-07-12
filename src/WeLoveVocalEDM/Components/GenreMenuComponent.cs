using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeLoveVocalEDM.Models;

namespace WeLoveVocalEDM.Components
{
    [ViewComponent(Name = "GenreMenu")]
    public class GenreMenuComponent : ViewComponent
    {
        public GenreMenuComponent(WeLoveVocalEDMContext dbContext)
        {
            DbContext = dbContext;
        }

        private WeLoveVocalEDMContext DbContext { get; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var genres = await DbContext.Genres.Select(g => g.Name).Take(9).ToListAsync();

            return View(genres);
        }
    }
}
