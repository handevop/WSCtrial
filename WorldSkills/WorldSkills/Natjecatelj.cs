using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldSkills
{
    public partial class Natjecatelj : Form
    {
        public Natjecatelj()
        {
            InitializeComponent();
        }

        private void Natjecatelj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSCDataSet.Natjecatelj' table. You can move, or remove it, as needed.
            this.natjecateljTableAdapter1.Fill(this.wSCDataSet.Natjecatelj);
            // TODO: This line of code loads data into the 'wSCDataSet3.Natjecatelj' table. You can move, or remove it, as needed.
            this.natjecateljTableAdapter.Fill(this.wSCDataSet3.Natjecatelj);

        }

        private void Natjecatelj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
