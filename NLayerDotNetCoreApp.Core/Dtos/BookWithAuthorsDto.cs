namespace NLayerDotNetCoreApp.Core.Dtos
{
    public class BookWithAuthorsDto : BaseDto
    {
        public string Name { get; set; }
        public List<BookAuthorDto> Authors { get; set; }
    }
}
