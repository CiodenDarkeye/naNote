using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nanote.Logic.Model;
using Nanote.Logic.Actions;
using Nanote.Logic.Data;

namespace Nanote.Logic
{
    public class Parser
    {
        readonly string _toParse;
        private Catalog _catalog;
        
        public Parser(
            string toParse, 
            Catalog catalog)
        {
            _toParse = toParse;
            _catalog = catalog;
            Categories = new HashSet<int>();
            ParseText();
        }

        public string Action { get; set; }
        public HashSet<int> Categories { get; set; }
        public string Payload { get; set; }

        private void ParseText()
        {
            StringBuilder payloadBuilder = new StringBuilder();

            foreach (string word in _toParse.Split(' '))
            {
                if(String.IsNullOrEmpty(Action))
                {
                    Action = word;
                }
                else if(word[0] == '#')
                {
                    // If it's a category, check to see if the category exists, then add it
                    var _categoryName = word.TrimStart('#');

                    if (!_catalog.CategoryList.Any(p => p.Name == _categoryName))
                    {
                        var cat = new Category() { Name = _categoryName };
                        _catalog.CategoryList.Add(cat);
                        Categories.Add(cat.Id);
                    }
                    else
                    {
                        Categories.Add(_catalog.CategoryList.First(p => p.Name == _categoryName).Id);
                    }
                }
                else
                {
                    payloadBuilder.Append($" {word}");
                }
            }
            Payload = payloadBuilder.ToString().Trim();
        }

        
    }
}
