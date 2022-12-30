using Microsoft.AspNetCore.Http;
using System;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid ID { get; set; }
        public IFormFile File { get; set; }

    }
}
