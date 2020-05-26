﻿using ConceptDemo.Contracts;
using EventsAndDelegates;
using System;
using Fundamentals;

namespace ConceptDemo.UI
{
    public class CSharpDemoHandler : AbstractDemoHandler
    {
        public override IDemoFactory SelectDemoFactory()
        {
            ShowDemoOptions();
            var demoChoice = int.Parse(Console.ReadLine());
            switch (demoChoice)
            {
                case 1:
                    return new DelegateDemoFactory();
                case 2:
                    return new FundamentalsDemoFactory();
                default:
                    return null;
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine(Utility.LineSeprator);
            Console.WriteLine("Available CSharp Demo:");
            Console.WriteLine("1. Events and Delegate");
            Console.WriteLine("2. Fundamentals Demo");
            Console.Write("Please Enter your choice for the demo type : ");
        }
    }
}