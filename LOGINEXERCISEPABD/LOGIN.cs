using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINEXERCISEPABD
{
    public partial class LOGIN : Form
    {
        DataTable dt;
        DataRow dr;
        String code;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            txtStatus.Enabled = true;
            txtKaryawan.Enabled = true;
            txtPeriode.Enabled = true;
            txtStatus.Text = "";
            txtKaryawan.Text = "";
            txtPeriode.Text = "";

            int ctr, len;
            string codeval;
            dt = exeDatabase1DataSet.Tables["Status_Karyawan"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["StatusKaryawan"].ToString();
            codeval = code.Substring(1, 3);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = exeDatabase1DataSet.Tables["Status_Karyawan"];
            dr = dt.NewRow();
            dr[0] = txtStatus.Text;
            dr[1] = txtKaryawan.Text;
            dt.Rows.Add(dr);
            status_KaryawanTableAdapter.Update(exeDatabase1DataSet);
            txtKaryawan.Text = System.Convert.ToString(dr[0]);
            txtKaryawan.Enabled = false;
            txtPeriode.Enabled = false;
            txtStatus.Enabled = false;
            this.status_KaryawanTableAdapter.Fill(this.exeDatabase1DataSet.Status_Karyawan);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtStatus.Text;
            dr = exeDatabase1DataSet.Tables["Status_Karyawan"].Rows.Find(code);
            dr.Delete();
            karyawanTableAdapter.Update(exeDatabase1DataSet);
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeDatabase1DataSet.Periode' table. You can move, or remove it, as needed.
            this.periodeTableAdapter.Fill(this.exeDatabase1DataSet.Periode);
            // TODO: This line of code loads data into the 'exeDatabase1DataSet.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.exeDatabase1DataSet.Karyawan);
            // TODO: This line of code loads data into the 'exeDatabase1DataSet.Status_Karyawan' table. You can move, or remove it, as needed.
            this.status_KaryawanTableAdapter.Fill(this.exeDatabase1DataSet.Status_Karyawan);

        }
    }
}
