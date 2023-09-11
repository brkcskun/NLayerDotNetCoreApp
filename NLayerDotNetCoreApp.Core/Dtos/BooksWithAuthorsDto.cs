namespace NLayerDotNetCoreApp.Core.Dtos
{
    public class BooksWithAuthorsDto : BookDto
    {
        public List<AuthorDto> Authors { get; set; }
    }
}
