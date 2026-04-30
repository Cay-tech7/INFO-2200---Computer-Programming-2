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
    public partial class MovieCategoryForm : Form
    {
        public MovieCategoryForm()
        {
            InitializeComponent();
        }

        private void MovieCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.CategoryCount' table. You can move, or remove it, as needed.
            this.categoryCountTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.CategoryCount);

        }
    }
}
