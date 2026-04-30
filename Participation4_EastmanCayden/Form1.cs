using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation4_EastmanCayden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLocalPhones_Click(object sender, EventArgs e)
        {
            LocalPhoneForm local = new LocalPhoneForm();
            local.ShowDialog(); // show is modeless, and showdialog is modal.
        }

        private void ButtonImportedPhones_Click(object sender, EventArgs e)
        {
            ImportedPhoneForm imported = new ImportedPhoneForm();
            imported.ShowDialog();
        }

        private void ButtonOnlinePhones_Click(object sender, EventArgs e)
        {
            OnlinePhoneForm online = new OnlinePhoneForm();
            online.ShowDialog();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
