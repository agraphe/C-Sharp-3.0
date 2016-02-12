using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_13_6____Explicit_Interfaces
{
    interface IStorable
    {
        void Read();
        void Write();
    }

    interface ITalk
    {
        void Talk();
        void Read();
    }

    // Modify Document to also implement ITalk
    public class Document : IStorable, ITalk
    {
        // the document constructor
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        // Implicit implementation
        public virtual void Read()
        {
            Console.WriteLine("Document Read Method for IStorable");
        }

        public void Write()
        {
            Console.WriteLine("Document Write Method for IStorable");
        }

        // Explicit implementation
        void ITalk.Read()
        {
            Console.WriteLine("Implementing ITalk.Read");
        }

        public void Talk()
        {
            Console.WriteLine("Implementing ITalk.Talk");
        }
    }

    class Tester
    {
        public void Run()
        {
            // Create a Document object
            Document theDoc = new Document("Test Document");
            IStorable isDoc = theDoc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }

            // Cast to an ITalk interface
            ITalk itDoc = theDoc as ITalk;
            if (itDoc != null)
            {
                itDoc.Read();
            }

            theDoc.Read();
            theDoc.Talk();
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
