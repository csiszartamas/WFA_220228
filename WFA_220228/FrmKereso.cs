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
    public partial class FrmKereso : Form
    {
        public string ConnectionString { get; set; }
        public FrmKereso()
        {
            ConnectionString =
                 @"Server = (localdb)\MSSQLLocalDB;" +
                  "Database = nyelviskola;";
            InitializeComponent();
            //FillDGV();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var r = new SqlCommand($"SELECT vizsgak.idopont, nyelvek.nyelv,vizsgak.szint FROM nyelvek,vizsgak,jelentkezesek WHERE nyelvek.id = vizsgak.nyelvid and vizsgak.sorsz = jelentkezesek.vizsga AND nyelvek.nyelv LIKE '%{CB_kereso.Text}%';", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2]);
                }


            }
        }

       

        private void FrmKereso_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
        }

        private void FillCB()
        {
            
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r = new SqlCommand("SELECT nyelvek.nyelv FROM nyelvek GROUP BY nyelvek.nyelv;", c).ExecuteReader();
                    while (r.Read()) CB_kereso.Items.Add(r[0]);
                }
            
        }

        private void CB_kereso_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void CB_kereso_TextChanged(object sender, EventArgs e)
        {
            CB_kereso.Text = "";
        }
    }
}
