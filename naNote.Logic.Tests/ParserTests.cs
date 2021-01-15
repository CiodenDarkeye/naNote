using System;
using System.Collections.Generic;
using Xunit;
using naNote.Logic;
using naNote.Logic.Model;
using System.Linq;
using naNote.Logic.Data;

namespace naNote.Logic.Tests
{
    public class ParserTests
    {
        [Fact]
        public void TestParsingIsWorking()
        {
            //Given
            Catalog catalog = new Catalog();
            string testAction = "ridiculous";
            string testCategory = "#Work";
            string testPayload = "What a week!";
            string parserPass = $"{testAction} {testCategory} {testPayload}";

            //When
            catalog.CategoryList.Add(new Category() { Name = "Work" });
            var testParser = new Parser(parserPass, catalog);
            int testCategoryId = catalog.CategoryList.First(p => p.Name == "Work").Id;

            //Then

            // Check that the inputted action matches the outputted action
            Assert.Equal(testParser.Action, testAction);
            // Check that the category matches
            Assert.Contains(catalog.CategoryList.FirstOrDefault(p => p.Name == "Work").Id, testParser.Categories);
            // Check that the payload works as well
            Assert.Equal(testParser.Payload, testPayload);
        }

        [Fact]
        public void HashesAreStripped()
        {
            //This tests whether or not hashes are stripped from stored category names.
            //Given
            Catalog catalog = new Catalog();
            string parserPass = "diary #help wow, what a crazy week this has been! #wow #worldofwarcraft";

            //When
            var testParser = new Parser(parserPass, catalog);

            //Then
            Assert.True(catalog.CategoryList.Count > 0);
            Assert.False(catalog.CategoryList.FirstOrDefault().Name.Contains('#'));
        }
    }
}
