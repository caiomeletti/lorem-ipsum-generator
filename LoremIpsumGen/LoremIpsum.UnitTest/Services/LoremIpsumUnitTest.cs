using LoremIpsum.Services.Services;

namespace LoremIpsum.UnitTest.Services
{
    public class LoremIpsumUnitTest
    {
        readonly LoremIpsumService _loremIpsumService;

        public LoremIpsumUnitTest()
        {
            _loremIpsumService = new LoremIpsumService();
        }

        [Fact(DisplayName = "Geração de palavras deve conter o número de palavras solicitadas")]
        public void Test1()
        {
            var number = 30;
            var result = _loremIpsumService.GenerateWords(number);
            var aWords = result.Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aWords.Length);

            number = 70;
            result = _loremIpsumService.GenerateWords(number);
            aWords = result.Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aWords.Length);
        }

        [Fact(DisplayName = "Geração de sentenças deve conter o número de sentenças solicitadas")]
        public void Test2()
        {
            var number = 5;
            var result = _loremIpsumService.GenerateSentece(number);
            var aSenteces = result.Split(",").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aSenteces.Length);

            number = 19;
            result = _loremIpsumService.GenerateSentece(number);
            aSenteces = result.Split(",").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aSenteces.Length);
        }

        [Fact(DisplayName = "Geração de parágrafos deve conter o número de parágrafos solicitados")]
        public void Test3()
        {
            var number = 3;
            var result = _loremIpsumService.GenerateParagraphs(number);
            var aParagraphs = result.Trim().Split(".").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aParagraphs.Length);

            number = 8;
            result = _loremIpsumService.GenerateParagraphs(number);
            aParagraphs = result.Trim().Split(".").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            Assert.Equal(number, aParagraphs.Length);
        }
    }
}
