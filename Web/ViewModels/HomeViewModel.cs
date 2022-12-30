using Core.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public Owner owner { get; set; }
        public List<PortfolioItem> PortfolioItems { get; set; }
    }
}
