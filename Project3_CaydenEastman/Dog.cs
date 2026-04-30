//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 2/13/2026
//Participation or Assignment #: Project 3

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.Text;

namespace Project3_CaydenEastman.Images
{
    //dog inherits from the animal base calss with the : symbol
    public class Dog : Animal
    {
        //pass in parameters into the animal base class constructor using the base keywork
        public Dog(string foodTypeParameter, string skinTypeParameter) : base(foodTypeParameter, skinTypeParameter)
        {
        }

        //override the pet method from the animal base class, this is required because its an abstract method
        public override string Pet()
        {
            return "He loves being pet";
        }

        //override the sound method from the animal base class, this is not required because its a virtual method, but we want to override it to make it specific to dogs
        public override string Sound()
        {
            return "Woof";
        }

    }
}
