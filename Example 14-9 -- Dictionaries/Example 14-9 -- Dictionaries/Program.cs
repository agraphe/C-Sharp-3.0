using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_9____Dictionaries
{
    public class Tester
    {
        static void Main()
        {
            // Create and initialize a new Dictionary.
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Alabama", "Montgomery");
            dict.Add("Alaska", "Juneau");
            dict.Add("Arizona", "Phoenix");
            dict.Add("Arkansas", "Little Rock");
            dict.Add("California", "Sacramento");
            dict.Add("Colorado", "Denver");
            dict.Add("Connecticut", "Hartford");
            dict.Add("Delaware", "Dover");
            dict.Add("Florida", "Tallahassee");
            dict.Add("Georgia", "Atlanta");
            dict.Add("Hawaii", "Honolulu");
            dict.Add("Idaho", "Boise");
            dict.Add("Illinois", "Springfield");
            dict.Add("Indiana", "Indianapolis");
            dict.Add("Iowa", "Des Moines");
            dict.Add("Kansas", "Topeka");
            dict.Add("Kentucky", "Frankfort");
            dict.Add("Louisiana", "Baton Rouge");
            dict.Add("Maine", "Augusta");
            dict.Add("Maryland", "Annapolis");
            dict.Add("Massachusetts", "Boston");
            dict.Add("Michigan", "Lansing");
            dict.Add("Minnesota", "St. Paul");
            dict.Add("Mississippi", "Jackson");
            dict.Add("Missouri", "Jefferson City");
            dict.Add("Montana", "Helena");
            dict.Add("Nebraska", "Lincoln");
            dict.Add("Nevada", "Carson City");
            dict.Add("New Hampshire", "Concord");
            dict.Add("New Jersey", "Trenton");
            dict.Add("New Mexico", "Santa Fe");
            dict.Add("New York", "Albany");
            dict.Add("North Carolina", "Raleigh");
            dict.Add("North Dakota", "Bismarck");
            dict.Add("Ohio", "Columbus");
            dict.Add("Oklahoma", "Oklahoma City");
            dict.Add("Oregon", "Salem");
            dict.Add("Pennsylvania", "Harrisburg");
            dict.Add("Rhode Island", "Providence");
            dict.Add("South Carolina", "Columbia");
            dict.Add("South Dakota", "Pierre");
            dict.Add("Tennessee", "Nashville");
            dict.Add("Texas", "Austin");
            dict.Add("Utah", "Salt Lake City");
            dict.Add("Vermont", "Montpelier");
            dict.Add("Virginia", "Richmond");
            dict.Add("Washington", "Olympia");
            dict.Add("West Virginia", "Charleston");
            dict.Add("Wisconsin", "Madison");
            dict.Add("Wyoming", "Cheyenne");

            // access a state

            Console.WriteLine("The capital of Massachusetts is {0}", dict["Massachusetts"]);

        }     
    }         
}            
