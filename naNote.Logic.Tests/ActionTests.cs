using Nanote.Logic.Actions;
using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace Nanote.Logic.Tests
{
    public class ActionTests
    {
        [Fact]
        public void DiaryTest()
        {
            //Assign
            Catalog catalog = new Catalog();

            //Act
            DiaryActions.AddDiary(catalog, new List<int>() { 0, 1, 2 }, "Diary #1");
            DiaryActions.AddDiary(catalog, new List<int>() { 4, 5, 6 }, "Diary #2");

            //Assert
            Assert.Equal("Diary #1", catalog.DiaryList.First().Entry);
            Assert.Equal(new List<int>() { 4, 5, 6 }, catalog.DiaryList.Last().CategoryIDs);

        }

        [Fact]
        public void NoteTest()
        {
            //Assign
            Catalog catalog = new Catalog();

            //Act
            NoteActions.AddNote(catalog, new List<int>() { 0, 1, 2 }, "Note #1");
            NoteActions.AddNote(catalog, new List<int>() { 4, 5, 6 }, "Note #2");

            //Assert
            Assert.Equal("Note #1", catalog.NoteList.First().Entry);
            Assert.Equal(new List<int>() { 4, 5, 6 }, catalog.NoteList.Last().CategoryIDs);
        }
    }
}
