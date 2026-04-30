//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 1/30/2026
//Participation or Assignment #: Assingment 2

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.

using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MO2_Assignment2EastmanCayden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Open teh nutrition.txt file
        //Read and process the contents of the txt file
        //add teh foods to the food dicationary
        //show the details of a selected food to the user

        Dictionary<string, Food> foodDictionary = new Dictionary<string, Food>();
    
        public MainWindow()
        {
            InitializeComponent();

            LoadFoodDetails();
        }


        /// <summary>
        /// Read the nutrition.txt file and add the food items to our food dictionary and combo box
        /// </summary>
        private void LoadFoodDetails()
        {
            //create a reader
            StreamReader reader;

            //create a varibale to hold the food values
            string[] currentFoodLine;

            try
            {
            //open the text file
                reader = File.OpenText("..\\..\\..\\nutrition.txt");

                //skip the headers
                reader.ReadLine();

                while (reader.EndOfStream == false)
                {
                    //split the current food line by tabs
                    currentFoodLine = reader.ReadLine().Split('\t');

                    //create a new food object with t he current food line values
                    Food newFood = new Food(currentFoodLine);

                    //add the new food object to the food dictionary
                    foodDictionary.Add(newFood.FoodName, newFood);

                    //add the food name to the combo box
                    ComboBoxFoods.Items.Add(newFood.FoodName);
                }

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("You did your best, try again!");
            }

        }
        private void ButtonShowFoodDetails_Click(object sender, RoutedEventArgs e)
        {
            //creat a new details window behind the scenes, dont show it yet
            DetailsWindow foodDetailsWindow = new DetailsWindow();

            //check if hte user actaully selected a food item form the combo box
            if ((ComboBoxFoods.SelectedItem != null))
            {
                //Grabe the name of the selected food
                string selectedFoodName = ComboBoxFoods.SelectedItem.ToString();

                //look up the selected food in the dictionary
                if (foodDictionary.TryGetValue(selectedFoodName, out Food selectedFood))
                { 
                    //if the food exists, we pass it into the dtails window
                    foodDetailsWindow.UpdateGUI(selectedFood);

                    //show the window to the user
                    foodDetailsWindow.ShowDialog();
                }
            }
            else
            {
            
            }

        }
    }
}