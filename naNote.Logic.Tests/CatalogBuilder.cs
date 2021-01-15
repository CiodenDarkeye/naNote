using naNote.Logic.Actions;
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
        public static Catalog BuildTestCatalog()
        {
            Catalog catalog = new Catalog();
            Parser[] pArr = new Parser[6];

            pArr[0] = new Parser("diary #bug #test1 this is a test of the first parser #bug2", catalog);
            pArr[1] = new Parser("diary #notepad #test2 test is the second line", catalog);
            pArr[2] = new Parser("diary #bug #test3 this #bug is a #bug test of #bug the first #bug parser #bug2", catalog);
            pArr[3] = new Parser("note #bug #note1 this #bug is a #bug test of #bug the first #bug parser #bug2", catalog);
            pArr[4] = new Parser("note #bug #note2 what #bug what #bug wow #bug the first #bug parser #bug2", catalog);
            pArr[5] = new Parser("note #bug #note3", catalog);

            foreach (var parse in pArr)
            {
                if (parse.Action == "note")
                {
                    NoteActions.AddNote(catalog, parse.Categories, parse.Payload);
                }
                else if (parse.Action == "diary")
                {
                    DiaryActions.AddDiary(catalog, parse.Categories, parse.Payload);
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
