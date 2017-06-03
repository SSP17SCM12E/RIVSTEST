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
// <summary>This class is used to print the data</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace RivsConsoleTest
{
    public class DataPrinter
    {
        public void PrintData(int[] arrayInput)
        {
            foreach (int value in arrayInput)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
