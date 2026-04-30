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
using Project3_CaydenEastman.Images;

namespace Project3_CaydenEastman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       //holds the curretnly selected animal
        Animal transformingAnimal;

        //this initializes the main window fand ties the UI and code-behind together
        public MainWindow()
        {
            InitializeComponent();

            RadioButtonDog.IsChecked = true; // Set the default selected radio button to Dog
        }


        /// <summary>
        /// runs when the Dog radio button is checked. It changes the image and result label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void RadioButtonDog_Checked(object sender, RoutedEventArgs e)
        {
            transformingAnimal = new Dog("Meat and Kettle", "Fur and sometimes hair"); //polymorphism, becaseu the animal can become a coyote, dog, or ferret
            ImageAnimal.Source = new BitmapImage(new Uri("/Images/Dog.jpg", UriKind.Relative)); //change the image to a dog
            LabelResults.Content = "Isn't he such a good boy?"; //change the label to a dog related message
        }
        private void RadioButtonCoyote_Checked(object sender, RoutedEventArgs e)
        {
            //polymorphism, becaseu the animal can become a coyote, dog, or ferret
            transformingAnimal = new Coyote("Meat and fruits", "Fur");
            ImageAnimal.Source = new BitmapImage(new Uri("/Images/Coyote.jpg", UriKind.Relative));
            LabelResults.Content = "It is not recommended pet them.";
        }

        private void RadioButtonFerret_Checked(object sender, RoutedEventArgs e)
        {
            transformingAnimal = new Ferret("Meat high in protein", "Short Hair");
            ImageAnimal.Source = new BitmapImage(new Uri("/Images/Ferret.jpg", UriKind.Relative));
            LabelResults.Content = "They have such limp bodies";
        }

        //these button click events call the corresponding method on the currently selected animal and display the result in the label
        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.Move();
        }

        private void ButtonEat_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.Eat();
        }

        private void ButtonPet_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.Pet();
        }

        private void ButtonSound_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.Sound();
        }

        private void ButtonFoodType_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.FoodType;
        }

        private void ButtonSkinType_Click(object sender, RoutedEventArgs e)
        {
            LabelResults.Content = transformingAnimal.SkinType;
        }

    }
}