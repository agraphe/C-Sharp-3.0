using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_11_2____Polymorphism
{
    public class Control
    {
        // these members are protected and thus visible
        // to derived class methods.
        protected int top;
        protected int left;

        // constructor takes two integers to
        // fix location on the console
        public Control (int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // simulates drawing the control
        public virtual void DrawControl()
        {
            Console.WriteLine("Control: drawing Control at {0}, {1}", top, left);
        }

    }  // end Window

    // ListBox derives from Control
    public class ListBox : Control
    {
        private string listBoxContents; // new member variable
        
        // constructor adds a parameter
        // and calls the base constructor
        public ListBox( int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }

        // an overridden version (note keyword) because in the
        // derived method we change the behavior
        public override void DrawControl()
        {
            base.DrawControl(); // invoke the base method
            Console.WriteLine("Writing string to the ListBox: {0}", listBoxContents);
        }

    }  // end ListBox

    // Button also derives from Control
    public class Button : Control
    {
        // constructor has no body because it simply calls
        // the base class constructor 
        public Button( int top, int left) : base(top, left)
        { }

        // an overridden version (note keyword) because in the
        // derived method we change the behavior
        public override void DrawControl()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }  // end Button

    public class Tester
    {
        static void Main()
        {
            Control myControl = new Control(1, 2);
            ListBox myListBox = new ListBox(3, 4, "Standalone listbox");
            Button myButton = new Button(5, 6);
            myControl.DrawControl();
            myListBox.DrawControl();
            myButton.DrawControl();

            Control[] controlArray = new Control[3];
            controlArray[0] = new Control(1, 2);
            controlArray[1] = new ListBox(3, 4, "Listbox in array");
            controlArray[2] = new Button(5, 6);

            for (int i = 0; i < controlArray.Length; i++)
            {
                controlArray[i].DrawControl();
            }   // end for
        }   // end Main
    }      // end Tester
}
