﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IsaevMA.Sprint2.SprintReview.V11.Lib;

namespace Tyuiu.IsaevMA.Sprint2.SprintReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
