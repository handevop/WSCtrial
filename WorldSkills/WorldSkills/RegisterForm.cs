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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSCDataSet2.Ustanova' table. You can move, or remove it, as needed.
            this.ustanovaTableAdapter.Fill(this.wSCDataSet2.Ustanova);
            // TODO: This line of code loads data into the 'wSCDataSet1.Natjecatelj' table. You can move, or remove it, as needed.
            UstanovaCB.SelectedIndex = -1;
        }

        void PostaviPocetno()
        {
            PonoviLozinkuTB.Text = "";
            LozinkaTB.UseSystemPasswordChar = false;
            EmailTB.Text = "";
            LozinkaTB.Text = "";
            UstanovaCB.Text = "";
            ImeTB.Text = "";
            PrezimeTB.Text = "";
        }

        string hash(string s)
        {
            s = EasyEncryption.MD5.ComputeMD5Hash(s);
            return s;
        }

        string nadiIdUstanove(string s)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ANT-HOH\SQLEXPRESS01;Initial Catalog=WSC;Integrated Security=True"); // zadavanje konekcije sa sql-om

            string query = "Select ID from Ustanova Where Naziv = '" + s.Trim() + "'"; // pomocni string sql za sql query naredbe

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); // zadavanje querya bazi
            DataTable dtbl = new DataTable(); // stvaranje nove datatable
            sda.Fill(dtbl); // punjenje datatable

            string ID = "";

            foreach (DataRow row in dtbl.Rows)
            {
                ID = row["ID"].ToString();
            }


            return ID;
        }

        void UpisiRegistraciju()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ANT-HOH\SQLEXPRESS01;Initial Catalog=WSC;Integrated Security=True"); // zadavanje konekcije sa sql-om
            sqlcon.Open();
            string ulaznaLozinka = LozinkaTB.Text.Trim(); // stavljanje textualne lozinke u pomocni string

            string hashLozinka = hash(ulaznaLozinka); // hash lozinke u md5

            string query = "Insert into Natjecatelj (Ime,Prezime,Email,Lozinka,UstanovaID) values ('" + ImeTB.Text.Trim() + "','" + PrezimeTB.Text.Trim() + "','" + EmailTB.Text.Trim() + "','" + hashLozinka.Trim() + "','" + Convert.ToInt32(nadiIdUstanove(UstanovaCB.Text.Trim())) + "');";
            SqlCommand sqlcomm = new SqlCommand(query, sqlcon); // zadavanje querya bazi
            sqlcomm.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            if (LozinkaTB.Text.Trim() == PonoviLozinkuTB.Text.Trim())
            {
                UpisiRegistraciju();
                MessageBox.Show("Registracija uspjela!");
                PostaviPocetno();
            }
            else
            {
                PostaviPocetno();
            }
        }

        private void PrijavaBTN_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
        }
    }
}
