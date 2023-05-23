﻿using Emerketo_webapp.Models;

namespace Emerketo_webapp.ViewModels
{
    public class HomeViewModel
    {
        public Product HeroDisplay { get; set; } = new Product();
        public IEnumerable<Product> NewProducts { get; set;} = new List<Product>();
        public IEnumerable<Product> PopularProducts { get; set; } = new List<Product>();
        public IEnumerable<Product> FeaturedProducts { get; set; } = new List<Product>();
    }
}
