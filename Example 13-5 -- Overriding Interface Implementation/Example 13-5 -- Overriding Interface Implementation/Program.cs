using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_13_5____Overriding_Interface_Implementation
{
    interface IStorable
    {
        void Read();
        void Write();
    }

    public class Note : IStorable
    {
        public Note(string s)
        {
            Console.WriteLine("Creating Note with: {0}", s);
        }

        // Note's version of Read() is virtual
        public virtual void Read()
        {
            Console.WriteLine("Note Read Method for IStorable");
        }

        // Note's version of Write() is NOT virtual!
        public void Write()
        {
            Console.WriteLine("Note Write Method for IStorable");
        }
    }

    public class Document : Note
    {
        public Document(string s) : base(s)
        {
            Console.WriteLine("Creating Document with: {0}", s);
        }

        // override the Read method
        public override void Read()
        {
            Console.WriteLine("Overriding the Read method for Document!");
        }

        // implement my own Write method
        public new void Write()
        {
            Console.WriteLine("Implementing a new Write method for Document!");
        }
    }

    class Tester
    {
        public void Run()
        {
            Note theNote = new Document("Test Document");

            theNote.Read();
            theNote.Write();

            Console.WriteLine("\n");

            IStorable isStorable = theNote as IStorable;
            if (isStorable != null)
            {
                isStorable.Read();
                isStorable.Write();
            }
            Console.WriteLine("\n");

            // This time create a reference to the derived type
            Document theDoc = new Document("Second Test");

            theDoc.Read();
            theDoc.Write();
            Console.WriteLine("\n");

            IStorable isStorable2 = theDoc as IStorable;
            if (isStorable != null)
            {
                isStorable2.Read();
                isStorable2.Write();
            }
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
