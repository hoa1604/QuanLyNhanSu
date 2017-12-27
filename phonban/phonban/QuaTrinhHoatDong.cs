using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonban
{
    public partial class QuaTrinhHoatDong : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public QuaTrinhHoatDong()
        {
            InitializeComponent();
        }

        private void cobNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuaTrinhHoatDong_Load(object sender, EventArgs e)
        {
            // ServiceReference1.phong phong = new ServiceReference1.phong();
            groupThaoTac.Visible = false;

            cobNhanVien.DataSource = service.CobNhanVien().ToList();
            cobNhanVien.ValueMember = "key";
            cobNhanVien.DisplayMember = "value";
            cobPhongBan.DataSource = service.CobPhongBan().ToList();
            cobPhongBan.ValueMember = "key";
            cobPhongBan.DisplayMember = "value";

            cobTkNhanVien.DataSource = service.CobNhanVien().ToList();
            cobTkNhanVien.ValueMember = "key";
            cobTkNhanVien.DisplayMember = "value";
            cobTkPhongBan.DataSource = service.CobPhongBan().ToList();
            cobTkPhongBan.ValueMember = "key";
            cobTkPhongBan.DisplayMember = "value";



            dgvNhanVienPhongBan.DataSource = service.LoadNhanVienPhongBan();
            dgvNhanVienPhongBan.Columns[0].HeaderText = "Mã";
            dgvNhanVienPhongBan.Columns[1].HeaderText = "Ngày chuyển phòng";
            dgvNhanVienPhongBan.Columns[2].HeaderText = "Tên nhân viên";
            dgvNhanVienPhongBan.Columns[3].Visible = false;
            dgvNhanVienPhongBan.Columns[4].Visible = false;
            dgvNhanVienPhongBan.Columns[5].HeaderText = "Tên phòng ban";
           


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ServiceReference1.nhanvienphongban2 nvpb = new ServiceReference1.nhanvienphongban2();
            if(cobNhanVien.SelectedValue.ToString()=="0")
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thêm thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cobPhongBan.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Bạn phải chọn phòng ban", "Thêm thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                     nvpb.Ma =txtMaNvpb.Text;
            nvpb.Nhanvienma = cobNhanVien.SelectedValue.ToString();
            nvpb.Phongbanma = cobPhongBan.SelectedValue.ToString();
            nvpb.Ngaychuyenphong =DateTime.Parse(dtpNgayChuyen.Value.ToShortDateString());
            bool result= service.InsertNhanVienPhongBan(nvpb);
            if(result==true)
            {
                DialogResult resultSuccess = MessageBox.Show("Thêm thành công", "Thêm thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultSuccess == DialogResult.OK)
                {
                    dgvNhanVienPhongBan.DataSource = service.LoadNhanVienPhongBan();
                    dgvNhanVienPhongBan.Columns[0].HeaderText = "Mã";
                    dgvNhanVienPhongBan.Columns[1].HeaderText = "Ngày chuyển phòng";
                    dgvNhanVienPhongBan.Columns[2].HeaderText = "Tên nhân viên";
                    dgvNhanVienPhongBan.Columns[3].Visible = false;
                    dgvNhanVienPhongBan.Columns[4].Visible = false;
                    dgvNhanVienPhongBan.Columns[5].HeaderText = "Tên phòng ban";
                }
                groupThaoTac.Visible = false;
            }
            else
            {
                DialogResult resultSuccess = MessageBox.Show("Không thể thêm bản ghi này!", "Thêm thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                }
            }
               

        }

        private void dtpNgayChuyen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvNhanVienPhongBan.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Xóa chuyển phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                bool resultDelete = service.DeleteNhanVienPhongBan(id);
                if(resultDelete == true)
                {
                    DialogResult resultSuccess = MessageBox.Show("Xóa thành công", "Xóa thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(resultSuccess==DialogResult.OK)
                    {
                        dgvNhanVienPhongBan.DataSource = service.LoadNhanVienPhongBan();
                        dgvNhanVienPhongBan.Columns[0].HeaderText = "Mã";
                        dgvNhanVienPhongBan.Columns[1].HeaderText = "Ngày chuyển phòng";
                        dgvNhanVienPhongBan.Columns[2].HeaderText = "Tên nhân viên";
                        dgvNhanVienPhongBan.Columns[3].Visible = false;
                        dgvNhanVienPhongBan.Columns[4].Visible = false;
                        dgvNhanVienPhongBan.Columns[5].HeaderText = "Tên phòng ban";
                    }
                }
                else
                {
                    DialogResult resultSuccess = MessageBox.Show("Không thể xóa bản ghi này!", "Xóa thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupThaoTac.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = true;
            txtMaNvpb.Text = service.IdNhanVienPhongBan().ToString();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupThaoTac.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = true;
            txtMaNvpb.Text= dgvNhanVienPhongBan.CurrentRow.Cells[0].Value.ToString();
            cobNhanVien.SelectedValue= dgvNhanVienPhongBan.CurrentRow.Cells[3].Value.ToString();
            cobPhongBan.SelectedValue = dgvNhanVienPhongBan.CurrentRow.Cells[4].Value.ToString();
            dtpNgayChuyen.Value =DateTime.Parse(dgvNhanVienPhongBan.CurrentRow.Cells[1].Value.ToString());

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ServiceReference1.nhanvienphongban2 update = new ServiceReference1.nhanvienphongban2();
            update.Ma = txtMaNvpb.Text;
            update.Nhanvienma = cobNhanVien.SelectedValue.ToString();
            update.Phongbanma = cobPhongBan.SelectedValue.ToString();
            update.Ngaychuyenphong = DateTime.Parse(dtpNgayChuyen.Value.ToShortDateString());
            bool result = service.UpdateNhanVienPhongBan(update) ;
            if (result == true)
            {
                DialogResult resultSuccess = MessageBox.Show("Sửa thành công", "Sửa thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultSuccess == DialogResult.OK)
                {
                    dgvNhanVienPhongBan.DataSource = service.LoadNhanVienPhongBan();
                    dgvNhanVienPhongBan.Columns[0].HeaderText = "Mã";
                    dgvNhanVienPhongBan.Columns[1].HeaderText = "Ngày chuyển phòng";
                    dgvNhanVienPhongBan.Columns[2].HeaderText = "Tên nhân viên";
                    dgvNhanVienPhongBan.Columns[3].Visible = false;
                    dgvNhanVienPhongBan.Columns[4].Visible = false;
                    dgvNhanVienPhongBan.Columns[5].HeaderText = "Tên phòng ban";
                }
                groupThaoTac.Visible = false;
            }
            else
            {
                DialogResult resultSuccess = MessageBox.Show("Bạn chỉ được quyền sửa ngày chuyển phòng!", "Sửa thông tin chuyển phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVienPhongBan.DataSource = service.SearchNhanVienPhongBan(cobTkNhanVien.SelectedValue.ToString(), cobTkPhongBan.SelectedValue.ToString());
            dgvNhanVienPhongBan.Columns[0].HeaderText = "Mã";
            dgvNhanVienPhongBan.Columns[1].HeaderText = "Ngày chuyển phòng";
            dgvNhanVienPhongBan.Columns[2].HeaderText = "Tên nhân viên";
            dgvNhanVienPhongBan.Columns[3].Visible = false;
            dgvNhanVienPhongBan.Columns[4].Visible = false;
            dgvNhanVienPhongBan.Columns[5].HeaderText = "Tên phòng ban";
        }
    }
}

