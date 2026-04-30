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
    public partial class jbForm : Form
    {
        public jbForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to open the search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFlavors_Click(object sender, EventArgs e)
        {
            JellyBellySearchForm searchForm = new JellyBellySearchForm();
            searchForm.ShowDialog();
        }

        /// <summary>
        /// Button to opent he category form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            JellyBellyCategoryForm categoryForm = new JellyBellyCategoryForm();
            categoryForm.ShowDialog();
        }

        /// <summary>
        /// closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jbForm_Load(object sender, EventArgs e)
        {

        }
    }
}


