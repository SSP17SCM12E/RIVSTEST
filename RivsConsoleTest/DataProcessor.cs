// ***********************************************************************
// Assembly         : RivsConsoleTest
// Author           : Subakar
// Created          : 06-03-2017
//
// Last Modified By : Subakar
// Last Modified On : 06-03-2017
// ***********************************************************************
// <copyright file="DataProcessor.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary>This class is used to process the data</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RivsConsoleTest
{
    public class DataProcessor
    {
        public int[] Simplify(int[] arrayInput)
        {
            int[] processedArray;
            processedArray = arrayInput.Distinct().ToArray();
            Array.Sort(processedArray);
            return processedArray;
        }
    }
}
