using LoremIpsum.Services.Interfaces;

namespace LoremIpsum.Services.Services
{
    public class LoremIpsumService : ILoremIpsumService
    {
        private readonly List<string> content;

        public LoremIpsumService()
        {
            content =
            [
                "Lorem ipsum dolor sit amet, ",
                "consectetur adipiscing elit, ",
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                "Ut enim ad minim veniam, ",
                "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ",
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. ",
                "Excepteur sint occaecat cupidatat non proident, ",
                "sunt in culpa qui officia deserunt mollit anim id est laborum.",
            ];
        }

        private static string Generate(int number, string separator, string[] array)
        {
            string result = string.Empty;

            var rounds = 1;
            var rest = 0;
            var numberOfItems = number;
            if (number > array.Length)
            {
                rounds = number / array.Length;
                rest = number - (rounds * array.Length);
                numberOfItems = array.Length;
            }

            for (int i = 0; i < rounds; i++)
            {
                result += string.Join(separator, array, 0, numberOfItems) + separator;
            }

            result += rest > 0
                ? " " + string.Join(separator, array, 0, rest) + separator
                : "";

            //result += separator;

            return result.Trim();
        }

        public string GenerateWords(int number)
        {
            var aWords = string.Join("", [.. content], 0, content.Count).Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return Generate(number, " ", aWords);
        }

        public string GenerateSentece(int number)
        {
            var aSentences = string.Join("", [.. content], 0, content.Count).Replace(".", ",").Split(",").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return Generate(number, ",", aSentences);
        }

        public string GenerateParagraphs(int number)
        {
            var aParagraphs = string.Join("", [.. content], 0, content.Count).Split(".").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return Generate(number, ".", aParagraphs);
        }
    }
}
