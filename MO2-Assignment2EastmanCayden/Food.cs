using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MO2_Assignment2EastmanCayden
{
    public class Food
    {
        // Properties for each food attribute (will hold the data from each column in the text file)
        public string FoodName { get; set; }
        public string Calcium { get; set; }
        public string ServingSize { get; set; }
        public string Weight { get; set; }
        public string PercentWater { get; set; }
        public string Calories { get; set; }
        public string Protein { get; set; }
        public string Carbohydrates { get; set; }
        public string Fiber { get; set; }
        public string Cholesterol { get; set; }
        public string TotalFat { get; set; }
        public string SaturatedFat { get; set; }
        public string MonosaturatedFat { get; set; }
        public string PolyunsaturatedFat { get; set; }
        public string Iron { get; set; }
        public string Magnesium { get; set; }
        public string Sodium { get; set; }
        public string Phosphorous { get; set; }
        public string CapRatio { get; set; }
        public string Potassium { get; set; }
        public string Zinc { get; set; }
        public string Niacin { get; set; }
        public string Thiamin { get; set; }
        public string Riboflavin { get; set; }
        public string VitaminA { get; set; }
        public string VitaminB6 { get; set; }
        public string VitaminC { get; set; }
        public string FoodType { get; set; }

        /// <summary>
        /// Assign each of the passed in values to the proptery variable when we parse the text file
        /// </summary>
        /// <param name="foodInfo"></param>
        public Food(string[] foodInfo)
        {
            // Initialize properties from the provided array
            FoodName = foodInfo[0];
            Calcium = foodInfo[1];
            ServingSize = foodInfo[2];
            Weight = foodInfo[3];
            PercentWater = foodInfo[4];
            Calories = foodInfo[5];
            Protein = foodInfo[6];
            Carbohydrates = foodInfo[7];
            Fiber = foodInfo[8];
            Cholesterol = foodInfo[9];
            TotalFat = foodInfo[10];
            SaturatedFat = foodInfo[11];
            MonosaturatedFat = foodInfo[12];
            PolyunsaturatedFat = foodInfo[13];
            Iron = foodInfo[14];
            Magnesium = foodInfo[15];
            Sodium = foodInfo[16];
            Phosphorous = foodInfo[17];
            CapRatio = foodInfo[18];
            Potassium = foodInfo[19];
            Zinc = foodInfo[20];
            Niacin = foodInfo[21];
            Thiamin = foodInfo[22];
            Riboflavin = foodInfo[23];
            VitaminA = foodInfo[24];
            VitaminB6 = foodInfo[25];
            VitaminC = foodInfo[26];
            FoodType = foodInfo[27];
        }
    }
}
