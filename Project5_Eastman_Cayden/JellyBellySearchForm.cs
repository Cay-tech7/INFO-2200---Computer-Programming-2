//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 3/20/2026
//Participation or Assignment #: Project 5

//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me,
//unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part,
//was directly created by Generative AI, unless explicitly stated in the assignment instructions,
//nor obtained from a subscription service. I understand that copying any source code, in whole or in part,
//unless specifically provided in the assignment, constitutes cheating,
//and that I will receive a zero on this project if I am found in violation of this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_Eastman_Cayden
{
    public partial class JellyBellySearchForm : Form
    {

        //Connect to our database
        MyJellyBellyDataModel connection = new MyJellyBellyDataModel();

        public JellyBellySearchForm()
        {
            InitializeComponent();

            //Create our query to grabl all the jelly bean froms the jelly belly table
            var JellyBellyQueryList = from jellyBelly in connection.JellyBellies
                                      select jellyBelly;

            //Exexute qurey
            //assign the converted data to the data grid view
            DataGridViewJellyBellies.DataSource = JellyBellyQueryList.ToList(); //tolist executes the query

            DataGridViewJellyBellies.Columns["JellyBellyID"].Visible = false; //hide the id
            DataGridViewJellyBellies.Columns[1].HeaderCell.Value = "Flavor"; 
            DataGridViewJellyBellies.Columns[2].HeaderCell.Value = "Category"; 
            }


        /// <summary>
        /// Filters teh datagrid view based on the text in the search box.
        /// It uses the contains method to filter the data based on the text in the search box. 
        /// It uses both query syntax and method syntax to demonstrate how to do the same thing in different ways.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Create our query (query syntax)
            var jellybellyFilterdLlist = from jb in connection.JellyBellies
                                      where jb.jellyBellyFlavor.Contains(TextBoxSearch.Text) //filter the data based on the text in the search box
                                      select jb;

            //Mehod syntax (anothe rway to do the query above)
            var jellyBellyMethodList = connection.JellyBellies.Where(jb => jb.jellyBellyFlavor
                                                              .Contains(TextBoxSearch.Text))
                                                              .Select(jb => jb);

            //execute the query
            DataGridViewJellyBellies.DataSource = jellybellyFilterdLlist.ToList(); //execute the query and assign it to the data grid view


        }

        /// <summary>
        /// Handles the click event to clear the search box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxSearch.Text = ""; //clear the search box
        }

        private void JellyBellySearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
