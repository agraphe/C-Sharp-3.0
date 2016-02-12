using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_13_4____Extending_Interfaces
{
    interface ICompressible
    {
        void Compress();
        void Decompress();
    }

    // extend ICompressible to log the bytes saved
    interface ILoggedCompressible : ICompressible
    {
        void LogSavedBytes();
    }

    public class Document : ILoggedCompressible
    {

        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        #region

        public void Compress()
        {
            Console.WriteLine("Executing Compress");
        }

        public void Decompress()
        {
            Console.WriteLine("Executing Decompress");
        }

        public void LogSavedBytes()
        {
            Console.WriteLine("Executing LogSavedBytes");
        }

        #endregion //ILoggedCompressible

    }

    class Tester
    {
        public void Run()
        {
            Document doc = new Document("Test Document");

            ILoggedCompressible myLoggedCompressible = doc as ILoggedCompressible;
            if (myLoggedCompressible != null)
            {
                Console.Write("\nCalling both ICompressible and ");
                Console.WriteLine("ILoggedCompressible methods...");
                myLoggedCompressible.Compress();
                myLoggedCompressible.LogSavedBytes();
            }
            else
            {
                Console.WriteLine("Something went wrong! Not ILoggedCompressible");
            }
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
