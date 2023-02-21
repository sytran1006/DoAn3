using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Specialized;

namespace Project1.Models
{
    public class ListProduct
    {
        private string[] color1;

        public int id { get; set; }
        public string? title { get; set; }
        public string? img { get; set; }
        public string? color { get ; set ; }
        public string? size { get; set; }
        public string? createdAt { get; set; }
        public string? price { get; set; }
        public string? category { get; set; }
    }
}
