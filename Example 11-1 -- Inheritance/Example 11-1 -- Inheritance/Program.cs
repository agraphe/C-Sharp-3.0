using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_11_1____Inheritance
{
    public class Control
    {
        // these members are private and thus invisible
        // to derived class methods

        private int top;
        private int left;

        // constructor takes two integers to
        // fix location on the console
        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // simulates drawing the control
        public void DrawControl()
        {
            Console.WriteLine("Drawing Control at {0}, {1}", top, left);
        }

    }

    // ListBox derives from Control
    public class ListBox : Control
    {
        private string mListBoxContents; // new member variable

        
        // constructor adds a parameter
        public ListBox(int top, int left, string theContent) : base(top, left) // call base constructor
        {
            mListBoxContents = theContent;
        }

        // a new version (note the keyword) because in the
        // derived method we change the behavior
        public new void DrawControl()
        {
            base.DrawControl(); // invoke the base method
            Console.WriteLine("Writing string to the ListBox: {0}", mListBoxContents);
        }
    }

    public class Tester
    {
        public static void Main()
        {
            // create a base instance
            Control myControl = new Control(5, 10);
            myControl.DrawControl();

            // create a derived instance
            ListBox lb = new ListBox(20, 30, "Hello world");
            lb.DrawControl();
        }
    }
}
