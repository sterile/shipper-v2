/*
 * Grading ID: 
 * Description: TBD
 * Variable Dictionary:
 */

using System;
using System.Collections.Generic;

namespace shipper_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address home1 = new Address("Helen C. Bice", "1163 Thompson Drive", "El Sobrante", "CA", 94803);
            Address home2 = new Address("Teresa T. Johnson", "3542 Farland Street", "Apt 101", "Westborough", "MA", 01581);
            Address home3 = new Address("Troy H. Thomas", "1299 Saints Alley", "Plant City", "FL", 33564);
            Address home4 = new Address("Susan K. McCrady", "3118 Chenoweth Drive", "Apt B3", "Clarksville", "TN", 37040);

            List<Parcel> letters = new List<Parcel>
            {
                new Letter(home1, home2, 0.43M),
                new Letter(home2, home3, 0.39M),
                new Letter(home4, home1, 0.47M),
                new Letter(home2, home4, 1.23M)
            };

            foreach (Letter letter in letters)
                Console.WriteLine(letter.ToString());

            // Validation testing

            string[][] validationList = new string[][]
            {
                // Name validation check
                new string[] { "    ", "727 Limer Street", "Rome", "GA", "30165"},
                // Address line 1 check
                new string[] { "Frances G. Ott", "", "Irving", "TX", "75060"},
                // City check
                new string[] { "Angela W. Morin", "1741 Alpha Avenue", null, "TX", "75433"},
                // State check
                new string[] { "Madeline L. Nault", "1059 James Avenue", "Wichita", null, "67213"},
                // Zip over check
                new string[] { "Steven C. Ek", "2642 Red Maple Drive", "Bellflower", "CA", "907066"},
                // Zip under check
                new string[] { "Carl B. Zepeda", "3733 Conference Center Way", "Washington", "VA", "-1"}
            };

            foreach(string[] testData in validationList)
            {
                try
                {
                    Address test = new Address(testData[0], testData[1], testData[2], testData[3], Int32.Parse(testData[4]));
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"{Environment.NewLine}Task failed successfully: {e.Message}");
                }
            }
        }
    }
}
