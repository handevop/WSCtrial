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
    public partial class LoginForm : Form
    {

        int prikaziLozinku = 1 , brojPokusanih = 0;

        void PrikazLozinke()
        {
            prikaziLozinku = (prikaziLozinku + 1) % 2;
            if (prikaziLozinku == 0)
            {
                LozinkaTB.UseSystemPasswordChar = true;
            }
            else
            {
                LozinkaTB.UseSystemPasswordChar = false;
            }
        }

        void PostaviPocetno()
        {
            checkBox2.Checked = true;
            prikaziLozinku = 1;
            LozinkaTB.UseSystemPasswordChar = false;
            EmailTB.Text = "";
            LozinkaTB.Text = "";
            //NatjecateljRB.Checked = true;
        }

        void spavanje(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        string hash(string s)
        {
            s = EasyEncryption.MD5.ComputeMD5Hash(s);
            return s;
        }

        void Pokusaji()
        {
            brojPokusanih++;
            if (brojPokusanih == 3) // ispitivanje broj pogresnih unosa
            {
                brojPokusanih = 0;
                spavanje(10000); // zaustaviti aplikaciju na 10 sekundi
            }
        }

        int ProvjeriPrijavu(string s)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ANT-HOH\SQLEXPRESS01;Initial Catalog=WSC;Integrated Security=True"); // zadavanje konekcije sa sql-om

            string ulaznaLozinka = LozinkaTB.Text.Trim(); // stavljanje textualne lozinke u pomocni string

            string hashLozinka = hash(ulaznaLozinka); // hash lozinke u md5

            string query = "Select * from " + s.Trim() + " Where Email = '" + EmailTB.Text.Trim() + "' and Lozinka = '" + hashLozinka.Trim() + "' "; // pomocni string sql za sql query naredbe

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); // zadavanje querya bazi
            DataTable dtbl = new DataTable(); // stvaranje nove datatable
            sda.Fill(dtbl); // punjenje datatable

            if (dtbl.Rows.Count == 0)
            {
                PostaviPocetno();
                MessageBox.Show("Neispravan Email ili lozinka!");
                Pokusaji();
                return 0;
            }
            
            return 1;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            PrikazLozinke();
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            if (NatjecateljRB.Checked == true)
            {
                if (ProvjeriPrijavu("Natjecatelj") == 1)
                {
                    Natjecatelj natjecateljFrm = new Natjecatelj();
                    natjecateljFrm.Show();
                    this.Hide();
                }
            }
            else if (SudacRB.Checked == true)
            {
                if (ProvjeriPrijavu("Sudac") == 1)
                {
                    Sudac sudacFrm = new Sudac();
                    sudacFrm.Show();
                    this.Hide();
                }
            }
            else
            {
               if (ProvjeriPrijavu("VoditeljNatjecanja") == 1)
                {
                    Voditelj voditeljFrm = new Voditelj();
                    voditeljFrm.Show();
                    this.Hide();
                }
            }
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            RegisterForm registerFrm = new RegisterForm();
            registerFrm.Show();
            this.Hide();
        }

        private void NatjecateljRB_CheckedChanged(object sender, EventArgs e)
        {
            RegisterBTN.Show();
        }

        private void SudacRB_CheckedChanged(object sender, EventArgs e)
        {
            RegisterBTN.Hide();
        }

        private void VoditeljRB_CheckedChanged(object sender, EventArgs e)
        {
            RegisterBTN.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
