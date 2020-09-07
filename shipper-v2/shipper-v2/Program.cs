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
            Address home4 = new Address("Susan K. McCrady", "3118 Chenoweth Drive", "Apt B4", "Clarksville", "TN", 37040);

            List<Parcel> letters = new List<Parcel>
            {
                new Letter(home1, home2, 0.43M),
                new Letter(home2, home3, 0.39M),
                new Letter(home4, home1, 0.47M),
                new Letter(home2, home4, 1.23M)
            };

            foreach (Letter letter in letters)
                Console.WriteLine(letter.ToString());
        }
    }
}
