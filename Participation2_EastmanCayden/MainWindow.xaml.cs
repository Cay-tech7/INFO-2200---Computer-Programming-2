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

namespace Participation2_EastmanCayden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //create a dictionary to hold our phone details
        Dictionary<string, Phone> phoneDictionary = new Dictionary<string, Phone>();

        //create a method that will show the phoen details of our selected phone in a new window

        /// <summary>
        /// Create a new main window and tie together our UI and code behind pages
        /// </summary>
        public MainWindow()
        {
            //Ties together our XAML UI and C# code behind
            InitializeComponent();

            LoadPhoneDetails();
        }

        /// <summary>
        /// Read teh phones.txt file and add the pones to our phone dictionary
        /// </summary>
        public void LoadPhoneDetails() 
        {
            //create our reader
            StreamReader reader;

            //create a string array to hold our phone values
            string[] splitPhoneValues;

            try
            {
                //open the text file for reading
                reader = File.OpenText("..\\..\\..\\phones.txt");

                //loop thorugh the phones.txt file
                while (reader.EndOfStream == false)
                {
                    //assign teh values of the current line the reader is on to the splitPhoneValues
                    splitPhoneValues = reader.ReadLine().Split(',');

                    //Create a new phone using the values from the splitPhoneValues array
                    Phone newPhone = new Phone(splitPhoneValues);

                    //Add the new phone name/model to the combo box
                    ComboBoxPhones.Items.Add(newPhone.Model);

                    //Add the new phone to the phone dictionary
                    phoneDictionary.Add(newPhone.Model, newPhone);
                }

                //Automatically selecta  phone by default in the combo box
                if (ComboBoxPhones.Items.Count > 0)
                {
                    ComboBoxPhones.SelectedIndex = 0;
                }

                //close the reader
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading phones.txt file");
            }
        }

        /// <summary>
        /// Handle the logic for when the show phone details button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //create a new phone details window, but don't show it yet
            PhoneDetailsWindow detailsWindow = new PhoneDetailsWindow();

            //create a variable to hold whateever phone the user selected in teh combo box
            string selectedModel = ComboBoxPhones.SelectedItem.ToString();

            //create a phone variable for our selected phone
            Phone selectedPhone;

            //check if the phone dictionary has the selected phone in it
            if (phoneDictionary.TryGetValue(selectedModel, out selectedPhone))
            {
                //update the phoen details GUI with our selected phone
                detailsWindow.UpdateGUI(selectedPhone);

                //show the phone details window
                detailsWindow.Show();
            }
        }
    }
}