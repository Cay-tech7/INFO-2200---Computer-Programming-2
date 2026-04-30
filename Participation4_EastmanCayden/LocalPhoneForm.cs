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
    public partial class LocalPhoneForm : Form
    {
        public LocalPhoneForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method is used to save the changes made to the local phone list. 
        /// It validates the input, ends the edit mode, and updates the database with the new information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneListBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.localPhoneListDbDataSet1);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPhoneForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneListDbDataSet1.PhoneList' table. You can move, or remove it, as needed.
            this.phoneListTableAdapter1.Fill(this.localPhoneListDbDataSet1.PhoneList);

        }

        /// <summary>
        /// This handles the TextChanged event of the TextBoxS control, 
        /// which is likely a search box for filtering the phone list by first name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxS_TextChanged(object sender, EventArgs e)
        {
            this.phoneListTableAdapter1.FillByFirstName(this.localPhoneListDbDataSet1.PhoneList, TextBoxS.Text);
        }
    }
}