// ***********************************************************************
// Assembly         : RivsConsoleTest
// Author           : Subakar
// Created          : 06-03-2017
//
// Last Modified By : Subakar
// Last Modified On : 06-03-2017
// ***********************************************************************
// <copyright file="Factory.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary>Factory Design Pattern</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace RivsConsoleTest
{
    public class Factory
    {
        public DataPreparation DataPreparationObject()
        {
            return new DataPreparation();
        }

        public DataPrinter DataPrinterObject()
        {
            return new DataPrinter();
        }

        public DataProcessor DataProcessorObject()
        {
            return new DataProcessor();
        }
    }
}
