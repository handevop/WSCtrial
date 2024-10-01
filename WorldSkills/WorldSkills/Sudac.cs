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
    public partial class Sudac : Form
    {
        public Sudac()
        {
            InitializeComponent();
        }

        private void Sudac_Load(object sender, EventArgs e)
        {

        }

        private void Sudac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
