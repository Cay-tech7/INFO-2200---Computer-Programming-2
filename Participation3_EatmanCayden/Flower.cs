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

    /// <summary>
    /// the flower clas inherits from the plant class
    /// the flower class is now a derived/child class of the plant base class
    /// the : indicates inheritance
    /// </summary>
    public class Flower : Plant
    {
        public Flower(string nameInput, string environmentInput, string typeInput) : base(nameInput, environmentInput, typeInput)
        {
            
        }

        public override string Sniff()
        {
            return "'sniiiiiiiiiiiiiffffFFFFFF' Smells good!";
        }
    }
}
