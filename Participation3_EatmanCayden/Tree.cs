//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 02/5/2026
//Participation or Assignment #: Participation 3

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Text;

namespace Participation3_EatmanCayden
{
    public class Tree : Plant
    {
        //inheritance includes inherting the constructors and other abstract methods
        public Tree(string nameInput, string environmentInput, string typeInput) : base(nameInput, environmentInput, typeInput)
        {

        }
        /// <summary>
        /// overriding the abstarct sniff method
        /// </summary>
        /// <returns></returns>
        public override string Sniff()
        {
            return "Smells like... wood?";
        }

        /// <summary>
        /// overriding the virutal Punch method, this is OPTIONAL
        /// </summary>
        /// <returns></returns>
        override public string Punch()
        {             
            return "Ouch! That's a freaking tree!";
        }
    }
}
