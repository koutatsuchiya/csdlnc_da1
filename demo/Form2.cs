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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void BindGrid(List<CT_HoaDon> hoaDons )
        {
            dataGridView1.Rows.Clear();
            foreach (var item in hoaDons)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaHD;
                dataGridView1.Rows[index].Cells[1].Value = item.MaSP;
                dataGridView1.Rows[index].Cells[2].Value = item.ThanhTien;
            }
        }
        private void LoadData()
        {
            ContextDB context = new ContextDB();
            List<CT_HoaDon> hoaDons = context.CT_HoaDon.ToList();
            BindGrid(hoaDons);

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ContextDB context = new ContextDB();
            List<CT_HoaDon> hoaDons = context.CT_HoaDon.ToList();
            var db = hoaDons.Where(p => Convert.ToDateTime(p.HoaDon.NgayLap).Month == dateTimePicker1.Value.Month).Select(p=>new {x=p.MaHD,y=p.MaSP,z=p.ThanhTien }).ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in db)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.x;
                dataGridView1.Rows[index].Cells[1].Value = item.y;
                dataGridView1.Rows[index].Cells[2].Value = item.z;
            }
        }
    }
}
