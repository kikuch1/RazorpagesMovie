using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // Display属性に定義した値をラベルタグヘルパーが取得する

        public int ID { get; set; }

        [Display(Name = "タイトル")]
        public string Title { get; set; }

        [Display(Name = "発売日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "ジャンル")]
        public string Genre { get; set; }

        [Display(Name = "価格（税込）")]
        public decimal Price { get; set; }
    }
}
