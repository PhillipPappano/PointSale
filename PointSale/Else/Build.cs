using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSale
{
    public partial class Build : Form
    {
        //the entry form to split between database management and the POS terminal
        public Build()
        {
            InitializeComponent();
        }
        //nitiates the POS terminal
        private void pos_Click(object sender, EventArgs e)
        {
            PoSForm a = new PoSForm();
            a.ShowDialog();
            a.Close();
        }
        //Initiates database management
        private void database_Click(object sender, EventArgs e)
        {
            DatabaseForm a = new DatabaseForm();
            a.ShowDialog();
            a.Close();
        }
    }
}
