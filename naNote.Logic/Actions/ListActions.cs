using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Actions
{
    public class ListActions
    {
        public static List<String> List(Catalog catalog, string payload)
        {
            switch (payload.Split(' ')[1])
            {
                case "diary":
                    return ListDiaries(catalog, payload);
                case "note":
                    // Not yet implemented
                    throw new NotImplementedException();
                default:
                    // Not yet implemented
                    throw new NotImplementedException();
            }
        }
        private static List<String> ListDiaries(Catalog catalog, string payload)
        {
            var retList = new List<String>();
            //Returning the last 10 diaries

            foreach (Diary diary in catalog.DiaryList.TakeLast(10))
            {
                retList.Add($"Entry#{diary.Id} at {diary.CreatedDtime.ToShortDateString()}" +
                    $"{diary.Entry}");
            }

            return retList;
        }
    }

 
}
