﻿using ConceptDemo.Contracts;
using System;
using System.Text;

namespace Fundamentals
{
    public class StringAndStringBuilder : IConceptDemo
    {
        private string _stringType;
        private StringBuilder _stringBuilderType;

        public StringAndStringBuilder()
        {
            _stringType = string.Empty;
        }

        public void ShowDemo()
        {
            AnalyzeString();
            AnalyzeStringBuilder();
            Console.WriteLine("Note: Object Hashcode shows us that object is changed or not.");
        }

        private void AnalyzeString()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("string analysis");
            Console.WriteLine("String Value: " + _stringType);
            Console.WriteLine("Object HashCode: " + _stringType.GetHashCode());

            Console.WriteLine("\nText Added => _stringType = \"Text Added.\"");
            _stringType = "Text Added.";
            Console.WriteLine("String Value: " + _stringType);
            Console.WriteLine("Object HashCode: " + _stringType.GetHashCode());

            Console.WriteLine("\nText Appended => _stringType = _stringType + \"Text Appended.\"");
            _stringType = _stringType + "Text Appended.";
            Console.WriteLine("String Value: " + _stringType);
            Console.WriteLine("Object HashCode: " + _stringType.GetHashCode());

            Console.WriteLine("\nText override => _stringType = \"Text override.\"");
            _stringType = "Text override.";
            Console.WriteLine("String Value: " + _stringType);
            Console.WriteLine("Object HashCode: " + _stringType.GetHashCode());
            Console.WriteLine("\nEverytime when a string operation is performed new string object is created.\nstring is an immutable type object.");
            Console.WriteLine(Utility.LineSeprator);

        }

        private void AnalyzeStringBuilder()
        {
            Console.WriteLine("\n"+Utility.LineSeprator);
            Console.WriteLine("StringBuilder analysis");
            Console.WriteLine("Object HashCode: " + _stringBuilderType?.GetHashCode());
            Console.WriteLine("\nText Added =>  _stringBuilderType = new StringBuilder(\"Text Initialized\")");
            _stringBuilderType = new StringBuilder("Text Initialized");
            Console.WriteLine("String Builder Value: " + _stringBuilderType);
            Console.WriteLine("Object HashCode: " + _stringBuilderType.GetHashCode());

            Console.WriteLine("\nText Appended => _stringBuilderType.Append(\"Text Appended.\")");
            _stringBuilderType.Append("Text Appended.");
            Console.WriteLine("String Builder Value: " + _stringBuilderType);
            Console.WriteLine("Object HashCode: " + _stringBuilderType.GetHashCode());

            Console.WriteLine("\nText override =>   _stringBuilderType.Clear();\n"
           +" _stringBuilderType.Append(\"Text Override\"); ");
            _stringBuilderType.Clear();
            _stringBuilderType.Append("Text Override");
            Console.WriteLine("String Builder Value: " + _stringBuilderType);
            Console.WriteLine("Object HashCode: " + _stringBuilderType.GetHashCode());

            Console.WriteLine("\nEverytime when a operation is performed object is not changed only content is changed.\nStringBuilder is a mutable type object.");
            Console.WriteLine(Utility.LineSeprator);
        }
    }
}
