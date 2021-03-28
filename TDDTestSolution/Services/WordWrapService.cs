using System.Text;
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
            var result = new StringBuilder();

            var counter = 0;
            foreach (var character in text ?? string.Empty)
            {
                if (character != ' ' && character != '\n')
                {
                    counter++;
                }
                result.Append(character);
                
                if(counter == CharacterCount)
                {
                    result.Append("\n");
                    counter = 0;
                }
            }

            return result.ToString();
        }
    }
}
