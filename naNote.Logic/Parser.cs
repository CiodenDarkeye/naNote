using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nanote.Logic.Model;

namespace Nanote.Logic
{
    public class Parser
    {
        readonly string _toParse;
        public List<Category> _categoryCatalog;
        public Parser(string toParse, List<Category> categories)
        {
            _toParse = toParse;
            _categoryCatalog = categories;
            Categories = new List<Category>();
            parseText();
        }

        public string Action { get; set; }
        public List<Category> Categories { get; set; }
        public string Payload { get; set; }

        private void parseText()
        {
            StringBuilder[] bArr = new StringBuilder[3]{
                new StringBuilder(),
                new StringBuilder(),
                new StringBuilder()
            };
            var builder = new StringBuilder();
            var mode_cat = false;
            //iterate over text

            foreach (char c in _toParse)
            {
                // Whitespace is a natural delimiter, so take an action based on it.
                if(char.IsWhiteSpace(c))
                {
                    // Action
                    if(String.IsNullOrEmpty(Action))
                    {
                        // While Action is null, everything goes there. Once you hit whitespace,
                        // store the builder as action.
                        Action = bArr[0].ToString();
                        continue;
                    }
                    
                    // Category
                    else if (mode_cat == true)
                    {
                        // when you hit whitespace while in category mode, store it
                        var cat = new Category(){Name = bArr[1].ToString()};
                        if(!_categoryCatalog.Any(p => p.Name == cat.Name))
                        {
                            _categoryCatalog.Add(cat);
                        }
                        Categories.Add(cat);
                        bArr[1].Clear();
                        mode_cat = false;
                        continue;
                    }

                    // Otherwise, keep building the payload
                    else
                    {
                        bArr[2].Append(c);
                        continue;
                    }   

                }
                
                // Starting category tracking
                else if (c=='#')
                {
                    // switch to category tracking mode when you hit a hash
                    mode_cat = true;
                }
                
                // Append to Action builder
                else if (String.IsNullOrEmpty(Action))
                {
                    bArr[0].Append(c);
                }
                
                // Category append
                else if (mode_cat == true)
                {
                    bArr[1].Append(c);
                }

                // Payload append
                else{
                    bArr[2].Append(c);
                }

                
            }
            Payload = bArr[2].ToString();
        }

    }
}
