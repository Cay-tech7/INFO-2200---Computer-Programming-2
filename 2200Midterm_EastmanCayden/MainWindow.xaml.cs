//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 02/19/2026
//Participation or Assignment #: Midterm Exam part 2

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

namespace _2200Midterm_EastmanCayden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Handles the Click event of the button by creating a Square instance, calculating its area, and displaying
        /// its details in a message box.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">The event data associated with the Click event.</param>
        private void ButtonSquare_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of Square with the name "MySquare", 4 sides, and area 0
            Square fourSquare = new Square("Square", 4, 0);

            // Call SetShapeArea() to compute the area based on the default length
            fourSquare.SetShapeArea();

            // Display the square's name, color, and area in a message box
            MessageBox.Show($"Name: {fourSquare.GetShapeName()}" +
                            $"\nArea: {fourSquare.Area}");
        }

    }
 

    /// <summary>
    /// Represents a generic geometric shape and provides common metadata shared by all shapes.
    /// </summary>
    /// <remarks>
    /// This abstract base class stores the common properties `Name`, `Sides`, and `Area`.
    /// Derived types should override <see cref="SetShapeArea"/> to compute the shape's area
    /// and implement <see cref="GetColor"/> to provide a color description.
    /// </remarks>
    public abstract class Shape
    {        //backing field for Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //backing field for sides
        private int _sides;

        public int Sides
        {
            get { return _sides; }
            set { _sides = value; }
        }

        //backing field for Area
        private double _area;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        //constructor with the three parameters
        public Shape(string shapeName, int shapeSides, double shapeArea)
        {
            Name = shapeName;
            Sides = shapeSides;
            Area = shapeArea;
        }

        public string GetShapeName()
        {
            return Name;
        }

        public virtual void SetShapeArea()
        {
            Area = 0;
        }

        public abstract string GetColor();
    }

    /// <summary>
    /// Represents a geometric shape with four equal sides and provides properties and methods specific to squares.
    /// </summary>
    /// <remarks>The Square class extends the Shape base class by adding properties for the square's color and
    /// side length. It overrides methods to calculate the area and retrieve the color of the square. By default, a new
    /// Square instance is initialized with a side length of 4 and a color of "Green". The area is computed as the
    /// square of the side length.</remarks>
    public class Square : Shape
    {        //backing field for SquareColore
        private string _squareColor;
        public string SquareColor
        {
            get { return _squareColor; }
            set { _squareColor = value; }
        }

        //backing field for SquareLength
        private double _squareLength;
        public double SquareLength
        {
            get { return _squareLength; }
            set { _squareLength = value; }
        }

        // Constructor with 3 parameters, calling the base constructor
        public Square(string name, int sides, double area)
            : base(name, sides, area)
        {
            // Set required default values
            SquareLength = 4;
            SquareColor = "Green";
        }

        // Override GetColor() to return SquareColor
        public override string GetColor()
        {
            return SquareColor;
        }

        // Override SetShapeArea() to compute area of a square
        public override void SetShapeArea()
        {
            Area = SquareLength * SquareLength;
        }


    }
}