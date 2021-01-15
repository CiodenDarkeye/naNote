using Xunit;
using naNote.Logic;
using naNote.Logic.Model;
using System.Linq;
using naNote.Logic.Data;

namespace naNote.Logic.Tests
{
    public class ModelTests
    {
        [Fact]
        public void SameCatalogObjectsDoNotShareIDs()
        {
            // Assign
            Catalog catalog = new Catalog();

            // Act
            catalog.CategoryList.Add(new Category() { Name = "Work" });
            catalog.CategoryList.Add(new Category() { Name = "Play" });

            // Assert
            Assert.NotEqual(catalog.CategoryList.Last().Id, catalog.CategoryList.First().Id);
        }

        [Fact]
        public void CatalogBreaker()
        {
            // Assign
            Catalog catalog = CatalogBuilder.BuildTestCatalog();

            // Act
            var retStr = catalog.ListText("diary");

            // Assert
            Assert.True(retStr.Count > 0);
        }
    }
}
