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
            Categories = new List<Category>();
            ParseText();
        }

        public string Action { get; set; }
        public List<Category> Categories { get; set; }
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
                    var cat = new Category() { Name = word.TrimStart('#')};
                    if (!_catalog.CategoryList.Any(p => p.Name == cat.Name))
                    {
                        _catalog.CategoryList.Add(cat);
                    }
                    Categories.Add(cat);
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
