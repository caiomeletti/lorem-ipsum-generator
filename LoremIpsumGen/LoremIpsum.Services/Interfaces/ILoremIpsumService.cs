namespace LoremIpsum.Services.Interfaces
{
    public interface ILoremIpsumService
    {
        string GenerateWords(int number);
        string GenerateSentece(int number);
        string GenerateParagraphs(int value);
    }
}
