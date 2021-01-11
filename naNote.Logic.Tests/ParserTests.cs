using System;
using System.Collections.Generic;
using Xunit;
using naNote.Logic;
using Nanote.Logic.Model;
using System.Linq;
using Nanote.Logic.Data;

namespace naNote.LogicTests
{
    public class ParserTests
    {
        [Fact]
        public void SimpleParse()
        {
        //Given
        Catalog catalog = new Catalog();
        string testAction = "ridiculous";
        string testCategory = "#Work";
        string testPayload = "What a week!";
        string parserPass = $"{testAction} {testCategory} {testPayload}";
        
        //When
        catalog.categoryList.Add(new Category(){Name="Work"});
        var testParser = new Parser(parserPass, catalog.categoryList);

        //Then

        // Check that the inputted action matches the outputted action
        Assert.Equal(testParser.Action, testAction);
        // Check that the category matches
        Assert.True(testParser.Categories.FirstOrDefault(p => p.Name == testCategory.TrimStart('#')) != null);
        // Check that the payload works as well
        Assert.Equal(testParser.Payload, testPayload);
        }
        
        [Fact]
        public void HashesAreStripped()
        {
        //Given
        Catalog catalog = new Catalog();
        string parserPass = "diary #help wow, what a crazy week this has been! #wow #worldofwarcraft";

        //When
        catalog.categoryList.Add(new Category(){Name="Work"});
        var testParser = new Parser(parserPass, catalog.categoryList);

        //Then
        Assert.False(testParser.Categories.FirstOrDefault().Name.Contains('#'));
        }
    }
}
