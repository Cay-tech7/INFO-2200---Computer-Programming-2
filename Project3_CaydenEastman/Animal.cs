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

namespace Project3_CaydenEastman
{
    //abstarct base class that all animal types inherit from
    public abstract class Animal
    {
        //Backing fields for the properties
        private string _foodType;
        private string _skinType;

        //Properties that allow us to get and set the food type and skin type of the animal
        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public string SkinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }

        //Constructor that takes two parameters and sets the food type and skin type of the animal
        public Animal(string foodTypeParameter, string skinTypeParameter)
        {
            _foodType = foodTypeParameter;
            _skinType = skinTypeParameter;
        }

        //Methods that all animals have, these can be overridden by derived classes if they want to provide a specific implementation, but they are not required to be overridden like the abstract methods
        public string Move()
        {
            return "The animal moves.";
        }

        public string Eat()
        {
            return "The animal eats.";
        }

        ///<summary>
        ///Abstract Method - must be overridetn in every derived class
        ///defines how each animal reacts when pet
        /// </summary>
        /// <returns></returns>
        public abstract string Pet(); 


        ///<summary>
        ///Abstract Method
        ///Needs to be implemented by any and all derived classes
        /// </summary>
        /// <returns></returns>
        public virtual string Sound()
        {
            return "Makes a typical animal noise";
        }
    }
}
