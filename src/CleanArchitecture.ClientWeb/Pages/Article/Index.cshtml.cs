﻿using System.Threading.Tasks;
using CleanArchitecture.Core.Data.DTO;
using CleanArchitecture.Core.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArchitecture.ClientWeb.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly IArticleService _articleService;

        public ArticleDTO Article { get; set; }

        public IndexModel(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task OnGetAsync(int id)
        {
            Article =
                await _articleService.GetArticleAsync(id); 
        }
    }
}