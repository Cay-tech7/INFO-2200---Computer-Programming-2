//Name: Cayden Eastman
//Class: INFO 2200
//Section: x01
//Professor: Say
//Date: 
//Participation or Assignment #: Participation 4

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

namespace Participation4_EastmanCayden
{
    public partial class OnlinePhoneForm : Form
    {
        public OnlinePhoneForm()
        {
            InitializeComponent();
        }

        private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uVUPhoneNumsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        /// <summary>
        /// This handles the Load event of the OnlinePhoneForm, which is triggered when the form is first loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlinePhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
            this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable);

        }
    }
}
