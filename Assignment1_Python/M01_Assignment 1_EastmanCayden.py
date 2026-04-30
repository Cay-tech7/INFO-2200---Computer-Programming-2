'''
Name: Cayden Eastman
Class: INFO 2200
Section:x01
Professor: Say
Date: 
Participation or Assignment #: MO1 Assignment 1 The College Search Form and Console App

By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
was directly created by Generative AI, unless explicitly stated in the assignment instructions,
nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
unless specifically provided in the assignment, constitutes cheating,
and that I will receive a zero on this project if I am found in violation of this policy.
'''
#!/usr/bin/env python3
import random 
def main():
    print("Wecome to Cayden's College Search App!\n")

    #grab user input
    user_input = input("Please enter the name of a college to find its city (or type 'random' for a random college)(x to extit): ").strip()
    
    #create a dictionary to hold the college and city values from the text file
    college_city_dict = {}

    #open the file for reading
    with open ("colleges.txt", "r") as file:
    #split each line in thext file into two values, college and city, then add them to the dictionary
        for line in file:
            current_college_city = line.strip().split(",")
            college_city_dict.update({current_college_city[0]: current_college_city[1]})

    #loop until the user wants to exit
    while user_input.lower() != 'x':
        #if random input then display a random college and city from the dictionary
        if user_input.lower() == "random":
            import random
            random_college = random.choice(list(college_city_dict.keys()))
            print(f"College: {random_college}\nCity: {college_city_dict[random_college]}\n")

        #if the user input matches a college in the dictionary then display the city
        elif user_input in college_city_dict:
            print(f"College: {user_input}\nCity: {college_city_dict[user_input]}\n") 

        else:
            #if not valid then we display an error message to the user
            print("Sorry, that college was not found in our database. Please try again.\n")
        user_input = input("Please enter the name of a college to find its city (or type 'random' for a random college)(x to exit): ").strip()

#call the main function to start the program
if __name__ == "__main__":
    main()
