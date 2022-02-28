using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_220228
{
    public partial class FrmVizsgazo : Form
    {

        public string ConnectionString { get; set; }
        public int Id { get; set; }
        public bool Dgvbolnyitott { get; set; }
        public int Year { get; }
        public FrmVizsgazo(int id, bool dgvbolnyitott)
        {
            ConnectionString =
                @"Server   = (localdb)\MSSQLLocalDB;" +
                 "Database = nyelviskola;";
            Id = id;
            Dgvbolnyitott = dgvbolnyitott;
            InitializeComponent();
            TB_id.Enabled = false;
        }
        

        private void FrmVizsgazo_Load(object sender, EventArgs e)
        {
            //TB_id.Text = ""+Id;
            //TB_nev.Text = "" + Nev;
            if (Dgvbolnyitott == true)
            {
                FillTB();
                BT_torles.Enabled = true;
                BT_modositas.Enabled = true;
                BT_uj.Enabled = false;
            }
            else if (Dgvbolnyitott == false)
            {
                FillTBedit();
                BT_torles.Enabled = false;
                BT_modositas.Enabled = false;
                BT_uj.Enabled = true;
            }
        }

        private void FillTBedit()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand($"SELECT max(jelentkezesek.sorsz) +1 FROM jelentkezesek", c).ExecuteReader();
                while (r.Read())
                {
                    TB_id.Text = r[0].ToString(); 
                }
            }
        }

        private void FillTB()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand($"SELECT jelentkezesek.sorsz,jelentkezesek.nev,jelentkezesek.mobil,jelentkezesek.szulev FROM jelentkezesek WHERE jelentkezesek.sorsz = {Id}", c).ExecuteReader();
                r.Read();
                
                    TB_id.Text = r[0].ToString();
                    TB_nev.Text = r[1].ToString();
                    TB_telefonszam.Text = r[2].ToString();
                    TB_szul.Text = r[3].ToString();
                
            }
        }

        private void BT_uj_Click(object sender, EventArgs e)
        {
            System.DateTime moment = new System.DateTime(2022);
            int year = moment.Year;
            using (var c = new SqlConnection(ConnectionString))
            {
                
                DialogResult response = MessageBox.Show("Létre szeretnéd hozni az új felhasználót?", "", MessageBoxButtons.YesNo);


                    if (response == DialogResult.Yes)
                    {
                        if (TB_id.Text.Length > 0 && TB_nev.Text.Length > 0 && TB_telefonszam.Text.Length == 8 && TB_szul.Text.Length == 4 && int.Parse(TB_szul.Text) <= DateTime.Now.Year)
                        {
                            c.Open();
                        new SqlCommand($"INSERT INTO jelentkezesek (sorsz, nev, mobil, szulev, vizsga)  VALUES ('{TB_id.Text}', '{TB_nev.Text}', '{TB_telefonszam.Text}', '{TB_szul.Text}', null);", c).ExecuteNonQuery();

                        this.Close();
                        MessageBox.Show("Sikeres felvétel!");
                        }
                        else
                            MessageBox.Show("Érvénytelen adatok! Ellenőrizd még1x");
                    }
                    else
                    {
                        MessageBox.Show("Szerkesztés megszakítva");
                    }
                
                
            }
        }

        private void BT_modositas_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Szerkeszteni akarod?", "", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    new SqlCommand($"UPDATE jelentkezesek SET sorsz = '{TB_id.Text}', nev = '{TB_nev.Text}', mobil = '{TB_telefonszam.Text}', szulev = '{TB_szul.Text}' WHERE sorsz = '{Id}';", c).ExecuteNonQuery();
                }
                this.Close();
                MessageBox.Show("Sikeres módosítás!");
            }
            else
            {
                MessageBox.Show("Szerkesztés megszakítva");
            }
        }

        private void BT_torles_Click(object sender, EventArgs e)
        {
            //DELETE FROM table_name WHERE condition;
            DialogResult response = MessageBox.Show("Biztosan törölni szeretnéd?", "", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    new SqlCommand($"DELETE FROM jelentkezesek WHERE sorsz = '{Id}';", c).ExecuteNonQuery();
                }
                this.Close();
                MessageBox.Show("Sikeres törlés!");
            }
            else
            {
                MessageBox.Show("Törlés megszakítva");
            }
        }

        
    }
}
