//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 
//Participation or Assignment #: Insert participation or assignment number

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.

using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EastmanCayden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.Movie);

        }

        /// <summary>
        /// Filter the movie datagridview based on the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillBySearch(this.iNFO2200_CrandallSayDataSet.Movie, TextBoxSearch.Text);
        }

        /// <summary>
        /// Sort the movie list in ascending order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByAscendingButton_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortByMovieTitleAscending(this.iNFO2200_CrandallSayDataSet.Movie);
        }

        /// <summary>
        /// Sort the movie list in descending order by movie title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByDescendingButton_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortByMovieTitleDescending(this.iNFO2200_CrandallSayDataSet.Movie);
        }

        /// <summary>
        /// Gets a lits of 20 reandom movies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get20RandomMoviesButton_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByRandomTwentyMovies(this.iNFO2200_CrandallSayDataSet.Movie);
        }

        /// <summary>
        /// display a count of all themovies in each category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieCategoryCountButton_Click(object sender, EventArgs e)
        {
           MovieCategoryForm categoryForm = new MovieCategoryForm();
           categoryForm.ShowDialog();
        }
    }
}
