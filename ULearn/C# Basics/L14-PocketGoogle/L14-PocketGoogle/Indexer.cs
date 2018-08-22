/*
В файле Indexer.cs реализуйте предложенные методы
Add. Этот метод должен индексировать все слова в документе. Разделители слов: { ' ', '.', ',', '!', '?', ':', '-','\r','\n' }; Сложность – O(document.Length)
GetIds. Этот метод должен искать по слову все id документов, где оно встречается. Сложность — O(result), где result — размер ответа на запрос
GetPositions. Этот метод по слову и id документа должен искать все позиции, в которых слово начинается. Сложность — O(result)
Remove. Этот метод должен удалять документ из индекса, после чего слова в нем искаться больше не должны. Сложность — O(document.Length)
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private Dictionary<int, Dictionary<string, List<int>>> texInDictionary = new Dictionary<int, Dictionary<string, List<int>>>();
        readonly char[] stopChars = { ' ', '.', ',', '!', '?', ':', '-', '\r', '\n' };


        public void Add(int id, string documentText)
        {
            if (!texInDictionary.ContainsKey(id))
            {
                texInDictionary.Add(id, new Dictionary<string, List<int>>());
            }

            int startPosition = 0;

            for (int i = 0; i < documentText.Length; i++)
            {
                if (!stopChars.Contains(documentText[i])) continue;

                string word = documentText.Substring(startPosition, i - startPosition).TrimStart().ToLower();

                if (word == "" || !char.IsLetter(word[0]))
                {
                    startPosition = i + 1;
                    continue;
                }

                if (texInDictionary[id].ContainsKey(word))
                {
                    texInDictionary[id][word].Add(startPosition);
                }
                else
                {
                    texInDictionary[id].Add(word, new List<int> {startPosition });
                }
                startPosition = i + 1;
            }
        }

        public List<int> GetIds(string word)
        {
            word = word.ToLower();
            var outputIds = texInDictionary
                .Where(dict => dict.Value.ContainsKey(word))
                .Select(dict => dict.Key)
                .ToList();
            return outputIds;
        }

        public List<int> GetPositions(int id, string word)
        {
            word = word.ToLower();
            if (texInDictionary[id].ContainsKey(word))
                return texInDictionary[id][word];
            return new List<int>();
        }

        public void Remove(int id)
        {
            texInDictionary.Remove(id);
        }
    }
}
