using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint6.TaskReview.V18.Lib;

namespace Tyuiu.PaulikKV.Sprint6.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5]
            {{1, 1, 2, 3, 6},
             {4, 1, 1, 5, 7 },
             {5, 6, 1, 1, 8 },
             {8, 5, 9 ,1, 9 },
             {2, 3, 1 ,1, 5 },
            };

            int c = 2;
            int k = 0;
            int l = 3;
            int res = ds.GetMatrix(mas, c, k, l);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
