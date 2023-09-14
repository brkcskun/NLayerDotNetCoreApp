namespace NLayerDotNetCoreApp.Core.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<BookAuthor> Books { get; set; }
    }
}
