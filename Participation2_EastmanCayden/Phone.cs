//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 1/23/2026
//Participation or Assignment #: Participation 2 

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.Text;

namespace Participation2_EastmanCayden
{
    /// <summary>
    /// Phone data type, this is our blueprint for any phone we make
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Constructor method for the phone, create the phone for us to use
        /// </summary>
        /// <param name="phoneValues"></param>
        public Phone(string[] phoneValues)
        {
            //Assign the values to the properites
            Make = phoneValues[0];
            Model = phoneValues[1];

            //We can parse the values before we assign them to the properties if needed
            DisplaySize = double.Parse(phoneValues[2]);
            Storage = int.Parse(phoneValues[3]);
            Price = decimal.Parse(phoneValues[4]);
        }

        /// <summary>
        /// Make property for the phone
        /// </summary>
        public string Make { get; set; }
        public string Model { get; set; }
        public double  DisplaySize { get; set; }
        public int Storage { get; set; }
        public decimal Price { get; set; }
    }
}
