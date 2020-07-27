using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Pages.Movies
{
    /// <summary>
    /// 一覧画面
    /// </summary>
    /// PageModel派生クラスは、<PageName>Modelと命名する
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        /// OnGetメソッドでも可
        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
            // returnは不要
        }
    }
}
