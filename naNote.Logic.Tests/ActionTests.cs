using Nanote.Logic.Actions;
using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Nanote.Logic.Tests
{
    public class ActionTests
    {
        [Fact]
        public void ActionTest()
        {
            //Assign
            Catalog catalog = CatalogBuilder.BuildTestCatalog();
            

            //Act
            var newList = ListActions.List(catalog, "list diary");
            foreach (var entry in newList)
            {
                Console.WriteLine(entry);
            }

            //Assert
            Assert.True(newList.Count == 3);
        }
    }
}
