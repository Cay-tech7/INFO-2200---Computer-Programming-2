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



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MO2_Assignment2EastmanCayden
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        public DetailsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// update the GUI with the selected food information
        /// </summary>
        /// <param name="selectedFood"></param>
        public void UpdateGUI(Food selectedFood)
        {
            LabelFoodName.Content = selectedFood.FoodName;
            LabelCalcium.Content = selectedFood.Calcium;
            LabelServingSize.Content = selectedFood.ServingSize;
            LabelWeight.Content = selectedFood.Weight;
            LabelPercentWater.Content = selectedFood.PercentWater;
            LabelCalories.Content = selectedFood.Calories;
            LabelProtein.Content = selectedFood.Protein;
            LabelCarbohydrates.Content = selectedFood.Carbohydrates;
            LabelFiber.Content = selectedFood.Fiber;
            LabelCholesterol.Content = selectedFood.Cholesterol;
            LabelTotalFat.Content = selectedFood.TotalFat;
            LabelSaturatedFat.Content = selectedFood.SaturatedFat;
            LabelMonosaturatedFat.Content = selectedFood.MonosaturatedFat;
            LabelPolyunsaturatedFat.Content = selectedFood.PolyunsaturatedFat;
            LabelIron.Content = selectedFood.Iron;
            LabelMagnesium.Content = selectedFood.Magnesium;
            LabelSodium.Content = selectedFood.Sodium;
            LabelPhosphorus.Content = selectedFood.Phosphorous;
            LabelCapRatio.Content = selectedFood.CapRatio;
            LabelPotassium.Content = selectedFood.Potassium;
            LabelZinc.Content = selectedFood.Zinc;
            LabelNiacin.Content = selectedFood.Niacin;
            LabelThiamin.Content = selectedFood.Thiamin;
            LabelRiboflavin.Content = selectedFood.Riboflavin;
            LabelVitaminA.Content = selectedFood.VitaminA;
            LabelVitaminB6.Content = selectedFood.VitaminB6;
            LabelVitaminC.Content = selectedFood.VitaminC;
            LabelFoodType.Content = selectedFood.FoodType;
        }
    }
}
