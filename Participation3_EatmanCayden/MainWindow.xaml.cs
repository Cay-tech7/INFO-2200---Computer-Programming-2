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

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Participation3_EatmanCayden
{
    public partial class MainWindow : Window
    {
        //populate the UI, add items to the combo boxes
        //verify the user's iput
        //handle the logic when combo box is changed
        //handle the logic when a plant is created and added
        //add a new plant to a dicitonary
        //show the details of a selected plant

        //create a plant dictionary to hold our newly created/added plants
        Dictionary<string, Plant> plantDictionary = new Dictionary<string, Plant>();
        public MainWindow()
        {
            InitializeComponent();
            LoadValues();
        }

        private void LoadValues()
        {
            // Load values into the combo boxes
            ComboBoxEnvironment.Items.Add("Desert");
            ComboBoxEnvironment.Items.Add("Forest");
            ComboBoxEnvironment.Items.Add("Tropical");

            ComboBoxType.Items.Add("Flower");
            ComboBoxType.Items.Add("Tree");
            ComboBoxType.Items.Add("Shrub");

            //select the first item in the combo boxes by default
            ComboBoxEnvironment.SelectedIndex = 0; 
            ComboBoxType.SelectedIndex = 0;
        }

        /// <summary>
        /// logic cthat handles which environemt image to show based on the user's selection in the environment combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Update environment image
        private void ComboBoxEnvironment_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBoxEnvironment.SelectedItem)
            {
                case "Forest":
                    //assign an image to our image source using a relative path to our image
                    ImageEnvironment.Source = new BitmapImage(new Uri("Images/forest.png", UriKind.Relative));
                    break;
                case "Desert":
                    //assign an image to our image source using a relative path to our image
                    ImageEnvironment.Source = new BitmapImage(new Uri("Images/desert.png", UriKind.Relative));
                    break;
                case "Tropical":
                    //assign an image to our image source using a relative path to our image
                    ImageEnvironment.Source = new BitmapImage(new Uri("Images/tropical.jpg", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }


        // logic that handles which type image is shown to the user
        private void ComboBoxType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboBoxType.SelectedItem)
            {
                case "Flower":
                    //assign an image to our image source using a relative path to our image
                    ImageType.Source = new BitmapImage(new Uri("Images/rose.png", UriKind.Relative));
                    break;
                case "Tree":
                    //assign an image to our image source using a relative path to our image
                    ImageType.Source = new BitmapImage(new Uri("Images/tree.jpg", UriKind.Relative));
                    break;
                case "Shrub":
                    //assign an image to our image source using a relative path to our image
                    ImageType.Source = new BitmapImage(new Uri("Images/shrub.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        //add a new plant to our plant dictionary
        private void ButtonAddPlant_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text) == false)
            {
                //polymorphism in action
                Plant plantObject = null;

                //grab the user's input
                string name = TextBoxName.Text;
                string environment = ComboBoxEnvironment.SelectedItem.ToString();
                string type = ComboBoxType.SelectedItem.ToString();


                //careate a new plant bases on the user's input for the type of plant they want to create
                switch (ComboBoxType.SelectedItem)
                {
                    case "Flower":
                        plantObject = new Flower(name, environment, type);
                        break;
                    case "Tree":
                        plantObject = new Tree(name, environment, type);
                        break;
                    case "Shrub":
                        plantObject = new Shrub(name, environment, type);
                        break;            
                    default:
                        break;
                }

                if (plantObject != null)
                { 
                    plantDictionary.Add(plantObject.Name, plantObject);
                    ListBoxPlants.Items.Add(plantObject.Name);
                }
                else
                {
                    MessageBox.Show("That plant has already been added. Please enter a different name");
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a name for your plant.");
            }
        }



        // Show Details Button
        private void ButtonShowDetails_Click(object sender, RoutedEventArgs e)
        {
            //check if a plant is selected in from the list box
            if (ListBoxPlants.SelectedIndex > -1)
            {
                //look up the selected plant in our dicationar
                if (plantDictionary.TryGetValue(ListBoxPlants.SelectedItem.ToString(), out Plant selectedPlant))
                {
                    PlantDetailsWindow detailsWindow = new PlantDetailsWindow();
                    detailsWindow.LabelName.Content = selectedPlant.Name;
                    detailsWindow.LabelEnvironment.Content = selectedPlant.Environment;
                    detailsWindow.LabelType.Content = selectedPlant.Type;
                    detailsWindow.SelectedPlant = selectedPlant;
                    detailsWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("PLease select a plant or I'll crash and burn.");
            }
        }
    }
}
