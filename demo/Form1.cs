using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.Models;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGrid(List<HoaDon> hoaDons)
        {
            dgvInfo.Rows.Clear();
            foreach (var item in hoaDons)
            {
                int index = dgvInfo.Rows.Add();
                dgvInfo.Rows[index].Cells[0].Value = item.MaHD;
                dgvInfo.Rows[index].Cells[1].Value = item.MaKH;
                dgvInfo.Rows[index].Cells[2].Value = item.NgayLap;
                dgvInfo.Rows[index].Cells[3].Value = item.TongTien;
            }
        }

        private void LoadData()
        {
            ContextDB context = new ContextDB();
            List<HoaDon> hoaDons = context.HoaDons.ToList();
            BindGrid(hoaDons);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContextDB context = new ContextDB();
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = txtID.Text;
            hoaDon.MaKH = txtName.Text;
            hoaDon.NgayLap = dtmDate.Value;
            hoaDon.TongTien = Convert.ToInt32(txtCost.Text);
            context.HoaDons.Add(hoaDon);
            context.SaveChanges();
            List<HoaDon> hoaDons = context.HoaDons.ToList();
            BindGrid(hoaDons);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
