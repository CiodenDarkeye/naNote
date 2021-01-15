using naNote.Logic.Data;
using naNote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naNote.Logic.Tests
{
    public static class CatalogBuilder
    {
        public static string[] Payloads { get; set; } = new string[6] 
        {
            "diary #bug #test1 this is a test of the first parser #bug2",
            "diary #notepad #test2 test is the second line",
            "diary #bug #test3 this #bug is a #bug test of #bug the first #bug parser #bug2",
            "note #bug #note1 this #bug is a #bug test of #bug the first #bug parser #bug2",
            "note #bug #note2 what #bug what #bug wow #bug the first #bug parser #bug2",
            "note #bug #note3"
        };


        

        public static Catalog BuildTestCatalog()
        {
            Catalog catalog = new Catalog();
            Parser[] pArr = new Parser[6];

            pArr[0] = new Parser(Payloads[0], catalog);
            pArr[1] = new Parser(Payloads[1], catalog);
            pArr[2] = new Parser(Payloads[2], catalog);
            pArr[3] = new Parser(Payloads[3], catalog);
            pArr[4] = new Parser(Payloads[4], catalog);
            pArr[5] = new Parser(Payloads[5], catalog);

            foreach (var parse in pArr)
            {
                if (parse.Action == "note")
                {
                    catalog.AddNote(parse.Categories, parse.Payload);
                }
                else if (parse.Action == "diary")
                {
                    catalog.AddDiary(parse.Categories, parse.Payload);
                }
            }

            return catalog;
        }

        public static List<string> ReturnExpectedStrings()
        {
            var expectedList = new List<String>()
            {
                "this is a test of the first parser",
                "test is the second line",
                "this is a test of the first parser"
            };

            return expectedList;
        }
    }
}
