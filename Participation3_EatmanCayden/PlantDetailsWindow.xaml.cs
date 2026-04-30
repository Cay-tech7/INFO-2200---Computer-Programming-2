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

using System.Windows;

namespace Participation3_EatmanCayden
{
    public partial class PlantDetailsWindow : Window
    {
        public Plant SelectedPlant { get; set; }

        public PlantDetailsWindow()
        {
            InitializeComponent();

        }

        private void ButtonSniff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(SelectedPlant.Sniff());
        }

        private void ButtonPunch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(SelectedPlant.Punch());
        }
    }
}
