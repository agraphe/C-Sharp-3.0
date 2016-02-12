using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace mynamespace
{
    public class Person
    {
        public DateTime geburtstag;

        public void Aufwachen()
        {
            geburtstag = new DateTime(1991, 09, 20);
            Aufgewacht.Invoke(this, null);
        }

        public int Alter
        {
            get
            {
                return Convert.ToInt32(DateTime.Now.Subtract(geburtstag).Days) ;
            }
        }

        public event EventHandler Aufgewacht;
    }
}



namespace Example_13_3____is_and_as
{
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }

    interface ICompressible
    {
        void Compress();
        void Decompress();
    }

    public class Note : IStorable
    {
        private string myString;

        public Note(string theString)
        {
            myString = theString;
        }

        public override string ToString()
        {
            return myString;
        }

        #region IStorable

        public void Read()
        {
            Console.WriteLine("Executing Note's Read Method for IStorable");
        }

        public void Write(object o)
        {
            Console.WriteLine("Executing Note's Write Method for IStorable");
        }

        public int Status { get; set; }

        #endregion // IStorable

    }

    public class Document : Note, ICompressible
    {
        private int documentID;
        public int ID
        {
            get { return this.documentID; }
        }

        public Document(string docString, int documentID) : base(docString)
        {
            this.documentID = documentID;
        }

        #region ICompressible

        public void Compress()
        {
            Console.WriteLine("Executing Document's Compress Method for ICompressible");
        }
        public void Decompress()
        {
            Console.WriteLine("Executing Document's Decompress Method for ICompressible");
        }
        #endregion  // ICompressible

    }  // end Document class


    public class MyString
    {
        private readonly char[] _c;

        public MyString(char[] c)
        {
            _c = c;
            
        }

        public MyString ToUpper()
        {
            // _c ändern und groß schreiben

            return new MyString((char[])_c.Clone());
        }

        public override string ToString()
        {
            return _c.ToString();
        }
    }


    class Tester
    {
        public void Run()
        {
            char[] helloWorld = new char[] {'H', 'e'};
            
            var my1 = new MyString(helloWorld).ToUpper().ToString(); // result: HE
            var my2 = new MyString(helloWorld).ToString(); // result: He

            string testString = "String ";
            Note[] myNoteArray = new Note[3];

            for (int i = 0; i < 3; i++)
            {
                string docText = testString + i.ToString();
                if (i % 2 == 0)
                {
                    Document myDocument = new Document(docText, (i + 5) * 10);
                    myNoteArray[i] = myDocument;
                }
                else
                {
                    Note myNote = new Note(docText);
                    myNoteArray[i] = myNote;
                }
            }

            foreach (Note theNote in myNoteArray)
            {
                Console.WriteLine("\nTesting {0} with IS", theNote);

                theNote.Read();     // all notes can do this
                if (theNote is ICompressible)
                {
                    ICompressible myCompressible = theNote as ICompressible;
                    myCompressible.Compress();
                }
                else
                {
                    Console.WriteLine("This storable object is not compressible.");
                }

                if (theNote is Document)
                {
                    Document myDoc = theNote as Document;

                    // clean cast
                    myDoc = theNote as Document;
                    Console.WriteLine("my documentID is {0}", myDoc.ID);
                }
            }

            foreach (Note theNote in myNoteArray)
            {
                Console.WriteLine("\nTesting {0} with AS", theNote);
                ICompressible myCompressible = theNote as ICompressible;
                if (myCompressible != null)
                {
                    myCompressible.Compress();
                }
                else
                {
                    Console.WriteLine("This storable object is not compressible.");
                }    // end else

                Document theDoc = theNote as Document;
                if (theDoc != null)
                {
                    Console.WriteLine("My documentID is {0}",  ((Document)theNote).ID);
                }
                else
                {
                    Console.WriteLine("Not a document.");
                }
            }
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }          // end class Tester
}
