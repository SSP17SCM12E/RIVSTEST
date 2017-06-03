// ***********************************************************************
// Assembly         : RivsConsoleTest
// Author           : Subakar
// Created          : 06-03-2017
//
// Last Modified By : Subakar
// Last Modified On : 06-03-2017
// ***********************************************************************
// <copyright file="Client.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace RivsConsoleTest
{
    class Client
    {
        /******************************************************************************************************
        *  Function Name: Main
        *
        *  Description:
        *      Main method which is called first
        *
        *  Parameter:

        *  Return:
        *      
        *
        *  Author:
        *      Subakar
        *
        ******************************************************************************************************/
        static void Main(string[] args)
        {
            int[] data;
            //Factory object creation 
            Factory factory = new Factory();
            //getting respective objects from factory
            DataProcessor DP = factory.DataProcessorObject();
            DataPrinter printer = factory.DataPrinterObject();
            DataPreparation dataPreparation = factory.DataPreparationObject();

            //getting the input data
            data = dataPreparation.GetData();
            //processing the data
            int[] sortedArray = DP.Simplify(data);
            //printin the data in console
            printer.PrintData(sortedArray);
        }
    }
}