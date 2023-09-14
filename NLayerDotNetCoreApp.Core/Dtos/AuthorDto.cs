namespace NLayerDotNetCoreApp.Core.Dtos
{
    public class AuthorDto : BaseDto
    {
        public string Name { get; set; }

        public ICollection<BookAuthorDto> Books { get; set; }
    }
}
