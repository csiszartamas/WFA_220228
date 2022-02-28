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
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        public FrmMain()
        {
            ConnectionString =
                 @"Server = (localdb)\MSSQLLocalDB;" +
                  "Database = nyelviskola;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var r = new SqlCommand($"SELECT jelentkezesek.sorsz, jelentkezesek.nev, nyelvek.nyelv,vizsgak.szint FROM nyelvek,vizsgak,jelentkezesek WHERE nyelvek.id = vizsgak.nyelvid and vizsgak.sorsz = jelentkezesek.vizsga;", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }

                
            }
        }

       

        private void ujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool dgvbolnyitott = false;
            var frm = new FrmVizsgazo(id, dgvbolnyitott);
            frm.ShowDialog();
        }

        private void vizsgakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmKereso().ShowDialog();
        }

        

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            bool dgvbolnyitott = true;
            var frm = new FrmVizsgazo(id, dgvbolnyitott);
            frm.ShowDialog();
        }
    }
}
