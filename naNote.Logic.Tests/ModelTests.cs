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
    }
}
