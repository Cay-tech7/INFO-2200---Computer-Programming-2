//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 3/20/2026
//Participation or Assignment #: Project 5

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.
using System;
using System.Data.Entity;
using System.Linq;

namespace Project5_Eastman_Cayden
{
    public class MyJellyBellyDataModel : DbContext
    {
        // Your context has been configured to use a 'MyJellyBellyDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project5_Eastman_Cayden.MyJellyBellyDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyJellyBellyDataModel' 
        // connection string in the application configuration file.
        public MyJellyBellyDataModel()
            : base("name=MyJellyBellyDataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.


        /// <summary>
        /// converst eh jelly beans from the database into a list of jelly bean objects wwe can use in our c# code and quary using LINQ
        /// </summary>
        public virtual DbSet<JellyBelly> JellyBellies { get; set; }
    }
}