using System;
using System.Collections.Generic;
using System.Data;

namespace BashNIPI1
{
    public class TableGenerator
    {
        public static List<TestData> GenerateTable()
        {
            Random rand = new Random();
            List<TestData> testDataList = new List<TestData>();
            for (int i = 0; i < 100; i++)
            {
                testDataList.Add(new TestData(i, rand));
            }

            return testDataList;
        }
    }
}
