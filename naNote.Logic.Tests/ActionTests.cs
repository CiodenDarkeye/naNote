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
            
            var catalog = new Catalog();
            var newCategory = new Category() { Name = "Work" };
            var diary1 = new Diary(){Entry = "Helper time!", Categories = new List<Category>() { newCategory } };
            var diary2 = new Diary(){ Entry = "Oh boy!", Categories = new List<Category>() { newCategory } };
            var diary3 = new Diary(){ Entry = "Even better!", Categories = new List<Category>() { newCategory } };
            catalog.CategoryList.Add(newCategory);
            catalog.DiaryList.AddRange(new List<Diary>() { diary1, diary2, diary3 });

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
