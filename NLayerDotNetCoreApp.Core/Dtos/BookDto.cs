namespace NLayerDotNetCoreApp.Core.Dtos
{
    public class BookDto:BaseDto
    {
        public string Name { get; set; }

        public ICollection<BookAuthorDto> Authors { get; set; }
    }
}
