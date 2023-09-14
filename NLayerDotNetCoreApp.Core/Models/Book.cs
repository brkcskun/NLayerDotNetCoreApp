namespace NLayerDotNetCoreApp.Core.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<BookAuthor> Authors { get; set; }
    }
}
