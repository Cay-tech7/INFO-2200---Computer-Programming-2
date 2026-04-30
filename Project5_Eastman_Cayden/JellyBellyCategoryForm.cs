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
    public partial class JellyBellyCategoryForm : Form
    {
        //connect to our database
        MyJellyBellyDataModel connection = new MyJellyBellyDataModel();

        public JellyBellyCategoryForm()
        {
            InitializeComponent();

            // add columns to our list view
            ListViewCategories.Columns.Add("Category");
            ListViewCategories.Columns.Add("Total");

            //create our query
            var jellyBellyCategoryCount = from jb in connection.JellyBellies
                                          group jb by jb.category into jc
                                          orderby jc.Count() descending
                                          select jc;

            //execute our query
            //the qurey is executed since it is used in FOREACH
            foreach (IGrouping<string, JellyBelly> jb in jellyBellyCategoryCount)
            {
                //For each category group count, grab the key (category name ( and the count of  jelly benas in that category and put them in an array to add to the list view
                string[] listviewValues = { jb.Key, jb.Count().ToString() }; //create an array to hold the values for the list view

                //create a new lilstview item with the string arraw
                ListViewItem lvi = new ListViewItem(listviewValues);

                //add the listview item to the listView
                ListViewCategories.Items.Add(lvi);
            }

            //resize the columns to fit the content
            ListViewCategories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            ListViewCategories.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ListViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}