//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 1/23/2026
//Participation or Assignment #: Participation 2 

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Participation2_EastmanCayden
{
    /// <summary>
    /// Interaction logic for PhoneDetailsWindow.xaml
    /// </summary>
    public partial class PhoneDetailsWindow : Window
    {
        public PhoneDetailsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates teh phone details GUI with the selected phone information
        /// </summary>
        public void UpdateGUI(Phone selectedPhone)
        {
            //assign values to the UI
            LabelMake.Content = selectedPhone.Make;
            LabelModel.Content = selectedPhone.Model;
            LabelDisplay.Content = $"{selectedPhone.DisplaySize} inches";
            LabelStorage.Content = $"{selectedPhone.Storage} GB";
            LabelPrice.Content = $"${selectedPhone.Price}";
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
