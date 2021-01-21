using naNote.Logic.Data;
using naNote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace naNote.Logic.Tests
{
    public class FileTests
    {
        [Fact]
        public void SaveAndLoadTest()
        {
            // arrange
            Catalog catalog = CatalogBuilder.BuildTestCatalog();

            // act
            Access.Save(catalog);

            catalog = new Catalog();
            Assert.True(catalog.DiaryList.Count == 0);

            catalog = Access.Load();


            // assert
            Assert.Contains(CatalogBuilder.ReturnExpectedStrings()[0], catalog.DiaryList.First().Entries.First());

        }

        
    }
}
