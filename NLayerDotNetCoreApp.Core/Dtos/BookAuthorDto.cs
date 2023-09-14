namespace NLayerDotNetCoreApp.Core.Dtos
{
    public class BookAuthorDto
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public BookDto Book { get; set; }
        public AuthorDto Author { get; set; }
    }
}
