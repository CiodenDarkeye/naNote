using Nanote.Logic.Actions;
using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Tests
{
    public static class CatalogBuilder
    {
        public static Catalog BuildTestCatalog()
        {
            Catalog catalog = new Catalog();
            var parser1 = new Parser("diary #bug #test1 this is a test of the first parser #bug2", catalog);
            var parser2 = new Parser("diary #notepad #test2 test is the second line", catalog);
            var parser3 = new Parser("diary #bug #test3 this #bug is a #bug test of #bug the first #bug parser #bug2", catalog);

            DiaryActions.AddDiary(catalog, parser1.Categories, parser1.Payload);
            DiaryActions.AddDiary(catalog, parser2.Categories, parser2.Payload);
            DiaryActions.AddDiary(catalog, parser3.Categories, parser3.Payload);

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
