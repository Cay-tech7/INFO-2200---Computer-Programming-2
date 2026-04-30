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
    /// this is our base calss, the other classes will inherit from it
    /// make this abstarct, only exsists as an idea/blueprint for other classes
    /// </summary>
    public abstract class Plant
    {
        // encapsulation inclueds properties, backing fields, and getters/setters to hide and protect data
        // Backing Fields (variables that hold the data/value for properties)
        private string _name;
        private string _environment;
        private string _type;


        /// <summary>
        /// constructor, tells the application how to make a plant object
        /// this will take in some parameters and pass them into the properites
        /// </summary>
        public Plant(string nameInput, string environmentInput, string typeInput)
        {
            //backing fields on the left, parameters on the right
            _name = nameInput;
            _environment = environmentInput;
            _type = typeInput;
        }

        //Properties
        public string Type
        {
            get { return _type; } 
            set { _type = value; }
        }

        public string Environment
        {
            get { return _environment; }
            set { _environment = value; }
        }


        // publilc-facing property for the name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Methods

        /// <summary>
        /// abstract method, this is a method we MUST implement in derived/child/inherited classes
        /// </summary>
        /// <returns></returns>
        public abstract string Sniff();


        /// <summary>
        /// virtual method, this is a method we MAY implement in a derived/child/ inherited class, it is OPTIONAL
        /// </summary>
        /// <returns></returns>
        public virtual string Punch()
        {
            //default value to return
            return "You punched it...bold move.";
        }


    }
}

