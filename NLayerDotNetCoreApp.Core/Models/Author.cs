namespace NLayerDotNetCoreApp.Core.Models
{
    public class Author : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BookAuthor> Books { get; set; }
    }
}
