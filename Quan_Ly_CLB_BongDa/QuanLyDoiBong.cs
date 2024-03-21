using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_CLB_BongDa
{
    public partial class QuanLyDoiBong : Form
    {
        DataTable dt = new DataTable();
        private int rowIndex = -1;
        public QuanLyDoiBong()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyDoiBong_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("TenDoiBong");
            dt.Columns.Add("QuocGia");
            dt.Columns.Add("NamThanhLap");
            dt.Columns.Add("HuanLuyenVien");
            dt.Columns.Add("dangHoatDong");

            dgvDoiBong.DataSource = dt;
        }

        DataTable data = new DataTable();

        private int IDtangdan()
        {
            
            if (data.Rows.Count > 0)
            {
                int id = (int)data.Rows[data.Rows.Count - 1]["ID"];
                return id + 1;
            }
            return 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            int iD = IDtangdan();
            string TenDoiBong = txtTenDoiBong.Text;
            string QuocGia = txtQuocGia.Text;
            string HuanLuyenVien = txtHuanLuyenVien.Text;
            var NamThanhLap = txtNamThanhLap.Text;
            var dangHoatDong = "";
            if(radioButton1.Checked == true)
            {
                dangHoatDong = "Co";
            }
            if(radioButton2.Checked == true)
            {
                dangHoatDong = "Khong";
            }

            DataRow row = dt.Rows[rowIndex];
            row["ID"] = iD;
            row["TenDoiBong"] = TenDoiBong;
            row["QuocGia"] = QuocGia;
            row["NamThanhLap"] = NamThanhLap;
            row["HuanLuyenVien"] = HuanLuyenVien;
            row["dangHoatDong"] = dangHoatDong;

            dt.Rows.Add(row);

            dgvDoiBong.DataSource = dt;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDoiBong.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDoiBong.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvDoiBong.Rows.Remove(row);
                    }
                }
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            string tenDB = txtTenDoiBong.Text;
            string quocGia = txtQuocGia.Text;
            string hlv = txtHuanLuyenVien.Text;
            var namThanhLap = txtNamThanhLap.Text;

            DataRow row = dt.Rows[rowIndex];
            row["ID"] = IDtangdan();
            row["Ten Doi Bong"] = tenDB;
            row["Quoc Gia"] = quocGia;
            row["Nam Thanh Lap"] = namThanhLap;
            row["Huan Luyen Vien"] = hlv;

        }

    }
}
