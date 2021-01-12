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
        public void CatalogObjectsDoNotShareIds()
        {
            // Assign
            Catalog catalog = new Catalog();

            // Act
            catalog.CategoryList.Add(new Category() { Name = "Work" });
            catalog.DiaryList.Add(new Diary() { Entry = "Wow, what a day!" });

            // Assert
            Assert.NotEqual(catalog.DiaryList.First().Id, catalog.CategoryList.First().Id);
        }
    }
}
