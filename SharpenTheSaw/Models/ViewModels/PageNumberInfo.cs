using System;
namespace SharpenTheSaw.Models.ViewModels
{
    public class PageNumberInfo
    {
        public int ItemsPerPage { get; set; }
        public int CurPage { get; set; }
        public int TotalItems { get; set; }

        // Calculate the number of pages
        public int NumPages => (int)(Math.Ceiling((decimal)TotalItems / ItemsPerPage));
    }
}
