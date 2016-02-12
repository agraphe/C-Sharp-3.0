using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_13_4
{
    interface IConvertible
    {
        string ConvertToCSharp( string stringToConvert );
        string ConvertToVB( string stringToConvert );
    }

    interface ICodeChecker : IConvertible
    {
        bool CheckCodeSyntax( string stringToCheck, string whichLang );
    }

    public class ProgramConverter : IConvertible
    {
        public ProgramConverter() // constructor
        {
            Console.WriteLine( "Creating ProgramConverter" );
        }
        
        public string ConvertToCSharp( string stringToConvert )
        {
            Console.WriteLine( "Converting the string you passed in to CSharp syntax" );
            return "This is a C# string.";
        }
        
        public string ConvertToVB( string stringToConvert )
        {
            Console.WriteLine( "Converting the string you passed in to VB syntax" );
            return "This is a VB string.";
        }
    }

    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public ProgramHelper() // constructor
        {
            Console.WriteLine( "Creating ProgramHelper" );
        }

        public bool CheckCodeSyntax( string stringToCheck, string whichLang )
        {
            switch ( whichLang )
            {
                case "CSharp":
                    Console.WriteLine("Checking the string {0} for C# Syntax", stringToCheck );
                    return true;
                case "VB":
                    Console.WriteLine("Checking the string {0} for VB Syntax", stringToCheck );
                   return true;
                default:
                    return false;
            }     
        }     
    }        

    class Tester
    {
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
        public void Run()
        {
            ProgramConverter[] converters = new ProgramConverter[4];
            converters[0] = new ProgramConverter();
            converters[1] = new ProgramHelper();
            converters[2] = new ProgramHelper();
            converters[3] = new ProgramConverter();
            foreach ( ProgramConverter pc in converters )
            {
                string vbString =  pc.ConvertToCSharp( "This is a VB string to convert.");
                Console.WriteLine( vbString );
                ProgramHelper ph = pc as ProgramHelper;
                if ( ph != null )
                {
                    ph.CheckCodeSyntax( vbString, "VB" );
                }
                else
                {
                    Console.WriteLine( "No vb syntax check - not a Program helper" );
                }
                string cSharpString = pc.ConvertToCSharp( vbString );
                Console.WriteLine( cSharpString );
                if ( ph != null )
                {
                    ph.CheckCodeSyntax( vbString, "CSharp" );
                }
                else
                {
                    Console.WriteLine( "No csharp syntax check - not a Program helper" );
                }
            } 
        }
   }    
}
