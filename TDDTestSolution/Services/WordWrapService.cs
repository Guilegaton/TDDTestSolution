﻿using System.Text;
using TDDTestSolution.Interfaces;

namespace TDDTestSolution.Services
{
    public class WordWrapService : IWordWrapService
    {
        public int CharacterCount { get; private set; }

        /// <summary>
        /// Create new instance of WordWrapService with specified number for wrapping
        /// </summary>
        /// <param name="characterCount">Number of characters (except whitespace " " and new line "\n" characters) for wrapping</param>
        public WordWrapService(int characterCount)
        {
            CharacterCount = characterCount;
        }

        /// <summary>
        /// Wrap string
        /// </summary>
        /// <param name="text">String for wrapping</param>
        /// <returns>Wrapped string</returns>
        public string WordWrap(string text)
        {
            var result = new StringBuilder();

            var counter = 0;
            var usableText = text ?? string.Empty;
            for (int i = 0; i < usableText.Length; i++)
            {
                var character = usableText[i];
                if (character != ' ' && character != '\n')
                {
                    counter++;
                }
                else if (character == '\n' && counter == 0)
                {
                    continue;
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
