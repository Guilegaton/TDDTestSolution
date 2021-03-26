using TDDTestSolution.Interfaces;

namespace TDDTestSolution.Services
{
    public class WordWrapService : IWordWrapService
    {
        public int CharacterCount { get; private set; }

        public WordWrapService(int characterCount)
        {
            CharacterCount = characterCount;
        }

        public string WordWrap(string text)
        {
            return string.Empty;
        }
    }
}
