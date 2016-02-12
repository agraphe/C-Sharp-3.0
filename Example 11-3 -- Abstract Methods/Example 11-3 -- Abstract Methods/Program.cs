using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_11_3____Abstract_Methods
{
    public abstract class Control
    {
        protected int top;
        protected int left;
        
        // constructor takes two integers to
        // fix location on the console
        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        // simulates drawing the control
        // notice: no implementation
        public abstract void DrawControl();

    }     // end class Control

    // ListBox derives from Control
    public class ListBox : Control
    {
        private string listBoxContents; // new member variable
        
        // constructor adds a parameter
        public ListBox( int top, int left, string contents) : base(top, left) // call base constructor
        {
            listBoxContents = contents;
        }

        // an overridden version implementing the
        // abstract method
        public override void DrawControl()
        {
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }
    }     // end class ListBox

    public class Button : Control
    {
        public Button( int top, int left) : base(top, left) { }

        // override the abstract method
        public override void DrawControl()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }        // end class Button

    public class Tester
    {
        static void Main()
        {
            Control[] controlArray = new Control[3];
            controlArray[0] = new ListBox(1, 2, "First ListBox");
            controlArray[1] = new ListBox(3, 4, "Second ListBox");
            controlArray[2] = new Button(5, 6);

            for (int i = 0; i < 3; i++)
            {
                controlArray[i].DrawControl();
            }     // end for loop
        }        // end main
    }           // end class Tester
}
