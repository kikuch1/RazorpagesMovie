using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 画面初期表示
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            return Page();
        }

        // BindProperty属性：クライアントで設定された値はMovieにBindされる
        [BindProperty]
        public Movie Movie { get; set; }

        /// <summary>
        /// 保存ボタン押下
        /// </summary>
        /// <returns></returns>
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // asyncキーワードを使うと、非同期メソッドとなる
            // 文中にawaitキーワードを使えるようになる
            // await：指定したTaskの完了を待つ、Taskの結果を取り出す
            // 戻り値は必ずTask/Task<T>になる
            // 非同期メソッドのなかでは、実行順序は順守されるが逐次実行されない

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);

            // ヴァリデーションチェックと追加処理はどちらが先でもよい
            await _context.SaveChangesAsync();

            // 戻り値がIActionResult, Task<IActionResult>の場合は、return
            return RedirectToPage("./Index");
        }
    }
}
