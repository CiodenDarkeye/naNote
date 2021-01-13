using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Nanote.Logic.Tests
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

            Assert.Equal(catalog.DiaryList.First().Entry, CatalogBuilder.ReturnExpectedStrings()[0]);

        }

        
    }
}
