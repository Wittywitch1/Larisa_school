using Androne_Larisa_lab2.Models;

namespace Androne_Larisa_lab2.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}