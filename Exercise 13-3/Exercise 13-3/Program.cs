using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_13_3
{
    interface IConvertible
    {
        string ConvertToCSharp(string stringToConvert);
        string ConvertToVB(string stringToConvert);
    }

    interface ICodeChecker : IConvertible
    {
        bool CheckCodeSyntax(string stringToCheck, string whichLang);
    }

    public class ProgramHelper : ICodeChecker
    {
        public ProgramHelper() // constructor
        {
            Console.WriteLine("Creating ProgramHelper");
        }

        public string ConvertToCSharp(string stringToConvert)
        {
            Console.WriteLine("Converting the string you passed in to CSharp syntax");
            return "This is a C# String.";
        }

        public string ConvertToVB(string stringToConvert)
        {
            Console.WriteLine("Converting the string you passed in to VB syntax");
            return "This is a VB String.";
        }

        public bool CheckCodeSyntax(string stringToCheck, string whichLang)
        {
            switch (whichLang)
            {
                case "CSharp":
                    Console.WriteLine("Checking the string for C# Syntax: {0}", stringToCheck);
                    return true;
                case "VB":
                    Console.WriteLine("Checking the string for VB Syntax: {0}", stringToCheck);
                    return true;
                default:
                    return false;
            }
        }
    }  // end class ProgramHelper

    class Tester
    {
        public void Run()
        {
            // Create a ProgramHelper object
            ProgramHelper theProgramHelper = new ProgramHelper();

            // convert a line of CSharp to VB
            string cSharpString = theProgramHelper.ConvertToCSharp("This is a VB string to convert.");
            Console.WriteLine(cSharpString);
            Console.WriteLine("Checking the string for syntax... Result {0}", theProgramHelper.CheckCodeSyntax(cSharpString, "CSharp"));
            
            // convert the converted line back to VB
            string vbString = theProgramHelper.ConvertToVB(cSharpString);
            Console.WriteLine(vbString);
            Console.WriteLine("Checking the string for syntax... Result {0}", theProgramHelper.CheckCodeSyntax(vbString, "VB"));
        } 

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    } 
}
