using Xunit;
using Nanote.Logic;
using Nanote.Logic.Model;
using System.Linq;
using Nanote.Logic.Data;

namespace Nanote.Logic.Tests
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
