using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_13_2
{
    interface IConvertible
    {
        string ConvertToCSharp(string stringToConvert);
        string ConvertToVB(string stringToConvert);
    }
    public class ProgramHelper : IConvertible
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
    } 

    class Tester
    {
        public void Run()
        {
            // Create a ProgramHelper object
            ProgramHelper theProgramHelper = new ProgramHelper();

            // convert a line of CSharp to vb
            string vbString = theProgramHelper.ConvertToVB("This is a VB String to convert.");
            Console.WriteLine(vbString);

            // convert the converted line back to CSharp
            string cSharpString = theProgramHelper.ConvertToCSharp(vbString);
            Console.WriteLine(cSharpString);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }     
}
