namespace NLayerDotNetCoreApp.Core.Models
{
    public class Book : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BookAuthor> Authors { get; set; }
    }
}
