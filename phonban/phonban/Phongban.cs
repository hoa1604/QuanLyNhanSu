using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace phonban
{
    public partial class frm_phongban : Form
    {
        ServiceReference1.Service1Client objService = new ServiceReference1.Service1Client();

        public frm_phongban()
        {
            InitializeComponent();
            showdata();

        }
        void showdata()
        {
            DataSet ds = new DataSet();

            ds = objService.SelectUserDetails();
            dgv_phongban.DataSource = ds.Tables[0];
        // dgv_phongban.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCells);


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = txt_ma.Text;
            objuse.Ten = txt_ten.Text;
            objuse.SDT = txt_sdt.Text;
            objuse.Email = txt_email.Text;
            objService.InsertUserDetails(objuse);
            showdata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = this.dgv_phongban.CurrentRow.Cells[0].Value.ToString();
            objuse.Ten = txt_ten.Text;
            objuse.SDT = txt_sdt.Text;
            objuse.Email = txt_email.Text;
            objService.Updatephongban(objuse);
            showdata();
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = dgv_phongban.SelectedCells[0].RowIndex;
            txt_ma.Text = dgv_phongban.Rows[i].Cells[0].Value.ToString();
            txt_ten.Text = dgv_phongban.Rows[i].Cells[1].Value.ToString();
            txt_sdt.Text = dgv_phongban.Rows[i].Cells[2].Value.ToString();
            txt_email.Text = dgv_phongban.Rows[i].Cells[3].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = (string)dgv_phongban.CurrentRow.Cells[0].Value;
            objService.DeleteUserDetails(objuse);
            showdata();
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
        }

        private void dgv_phongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_phongban_Load(object sender, EventArgs e)
        {

        }

        //private void dgv_phongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ServiceReference1.phong objuse = new ServiceReference1.phong();
        //    string id = dgv_phongban.CurrentRow.Cells[0].Value.ToString();

        //    object newnv = object.Single(s => s.ma == id);
        //    txt_manv.Text = newnv.ma;
        //    txt_hoten.Text = newnv.ten;
        //}
    }
}
