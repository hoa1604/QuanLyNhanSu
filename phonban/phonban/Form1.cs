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
using System.IO;


namespace phonban
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client nv = new ServiceReference1.Service1Client();
     //   ServiceReference2.Service1Client nv = new ServiceReference2.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        DataGridView dt;
        public Form1(DataGridView dgv_dsnv)
        {
            InitializeComponent();
            dgv_dsnv = dt;
        }
      public  void show()
        {
            DataSet ds1 = new DataSet();

            ds1 = nv.SelectUserDetails();
            dgv_phongban.DataSource = ds1.Tables[0];


            DataSet ds = new DataSet();

            ds = nv.LoadNhanvien();
            dgv_dsnv.DataSource = ds.Tables[0];

            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            //
            cmb_tinhtranghonnhan.Items.Clear();
            cmb_tinhtranghonnhan.Items.Add("Đã kết hôn");
            cmb_tinhtranghonnhan.Items.Add("Chưa kết hôn");
            // dgv_phongban.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCells);
            //dgv_dsnv.Columns[0].HeaderText = "Mã nhân viên";
            //dgv_dsnv.Columns[1].HeaderText = "Tên nhân viên";
            //dgv_dsnv.Columns[2].HeaderText = "Ngày Sinh";
            //dgv_dsnv.Columns[3].HeaderText = "Giới Tính";
            //dgv_dsnv.Columns[4].HeaderText = "Địa chỉ";
            //dgv_dsnv.Columns[5].HeaderText = "Ảnh";

        }

        private void dgv_dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceReference2.Nhanvien nv = new ServiceReference2.Nhanvien();
            int i = dgv_dsnv.SelectedCells[0].RowIndex;
            string id = dgv_dsnv.CurrentRow.Cells[0].Value.ToString();
            txt_manv.Text = dgv_dsnv.Rows[i].Cells[0].Value.ToString();
            txt_hoten.Text = dgv_dsnv.Rows[i].Cells[1].Value.ToString();
            //txt_ten.Text = dgv_phongban.Rows[i].Cells[1].Value.ToString();
            dtk_ngaysinh.Text = dgv_dsnv.Rows[i].Cells[2].Value.ToString();
            cmb_gioitinh.Text = dgv_dsnv.Rows[i].Cells[22].Value.ToString();
           txt_sdt.Text= dgv_dsnv.Rows[i].Cells[15].Value.ToString();
            txt_email.Text = dgv_dsnv.Rows[i].Cells[16].Value.ToString();
            txt_noisinh.Text=dgv_dsnv.Rows[i].Cells[6].Value.ToString();
            txt_quequan.Text= dgv_dsnv.Rows[i].Cells[5].Value.ToString();
           txt_thuongtru.Text=dgv_dsnv.Rows[i].Cells[7].Value.ToString();
            txt_tamtru.Text=dgv_dsnv.Rows[i].Cells[8].Value.ToString();
            txt_quoctich.Text= dgv_dsnv.Rows[i].Cells[9].Value.ToString();
            txt_tongiao.Text= dgv_dsnv.Rows[i].Cells[10].Value.ToString();
            txt_cmtnd.Text= dgv_dsnv.Rows[i].Cells[11].Value.ToString();
            dtp_ngaycap.Text= dgv_dsnv.Rows[i].Cells[12].Value.ToString();
            txt_noicap.Text= dgv_dsnv.Rows[i].Cells[13].Value.ToString();
            txt_ngoaingu.Text= dgv_dsnv.Rows[i].Cells[18].Value.ToString();
            txt_dantoc.Text= dgv_dsnv.Rows[i].Cells[20].Value.ToString();
            cmb_tinhtranghonnhan.Text= dgv_dsnv.Rows[i].Cells[23].Value.ToString();

            try
            {
                string path = dgv_dsnv.CurrentRow.Cells[4].Value.ToString();
                if (!string.IsNullOrWhiteSpace(path))
                {
                    MemoryStream ms = new MemoryStream((byte[])dgv_dsnv.CurrentRow.Cells[4].Value);
                    ptb_anh.Image = Image.FromStream(ms);

                }
            }

            catch (Exception)
            {
                ptb_anh.Image = null;
            }

            //txt_sdt.Text = dgv_phongban.Rows[i].Cells[2].Value.ToString();
            //txt_email.Text = dgv_phongban.Rows[i].Cells[3].Value.ToString();
            //  nv = nv.s(s => s.ma == id);
            //     nv.Gioitinh = Boolean.Parse(gioitinh);

            //    dtk_ngaysinh.Text = nv.Ngaysinh.ToString();

            //if (nv.Gioitinh==false)
            //{
            //    cmb_gioitinh.Text = "Nữ";
            //}
            //else
            // if (nv.Gioitinh == true)
            //{
            //    cmb_gioitinh.Text = "Nam";
            //}

        }

        private byte[] convertFilToBytes(string spath)
        {

            byte[] data = null;
            FileInfo finfo = new FileInfo(spath);
            long numBytes = finfo.Length;
            FileStream fs = new FileStream(spath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)numBytes);
            return data;

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ServiceReference1.Nhanvien1 o = new ServiceReference1.Nhanvien1();
            //ServiceReference1.Nhanvien objuse = new ServiceReference1.Nhanvien();
            if (dgv_dsnv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn dữ liệu để xóa!", "Thông báo");
                return;
            }
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {

                o.Ma = (string)dgv_dsnv.CurrentRow.Cells[0].Value;
               nv.DeleteNhanvien(o);
                show();
            }
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            ServiceReference2.Service1Client nv = new ServiceReference2.Service1Client();
           // ServiceReference2.Nhanvien1 objuse = new ServiceReference2.Nhanvien1();

            //  QLNhanSuEntities db = new QLNhanSuEntities();
            //     var Lst = (from s in nv.LoadNhanvien() where (s.ma.Contains(txt_timkiem.Text) && (s.status == null)) select s).ToList();
            //dgv_dsnv.DataSource = Lst;
            //txt_manv.DataBindings.Clear();
            //txt_hoten.DataBindings.Clear();
            //txt_cmtnd.DataBindings.Clear();
            //txt_manv.DataBindings.Add("text", Lst, "ma");
            //txt_hoten.DataBindings.Add("text", Lst, "ten");
            //txt_cmtnd.DataBindings.Add("text", Lst, "soCMT");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ServiceReference1.Nhanvien1 objuse = new ServiceReference1.Nhanvien1();
//            objuse.Ma = this.dgv_dsnv.CurrentRow.Cells[0].Value.ToString();
            objuse.Ten = txt_hoten.Text;
            objuse.Ngaysinh = DateTime.Parse(dtk_ngaysinh.Text);
            Boolean gioiTinh = false;
            if (cmb_gioitinh.Text == "Nam")
            {
                gioiTinh = true;
            }
            else
                gioiTinh = false;
            objuse.Gioitinh = gioiTinh;
            try
            {
                MemoryStream str1 = new MemoryStream();
                ptb_anh.Image.Save(str1, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] pic = str1.ToArray();
                objuse.Anh = pic;
            }
            catch
            {
                objuse.Anh = null;

            }
            objuse.Quequan = txt_quequan.Text;
            objuse.Noisinh = txt_noisinh.Text;
            objuse.Hokhauthuongtru = txt_thuongtru.Text;
         //   objuse.Diachilienlac = txt_tamtru.Text;
            objuse.Quoctich = txt_quoctich.Text;
            objuse.Tongiao = txt_tongiao.Text;
            objuse.CMT = txt_cmtnd.Text;
            objuse.Ngaycap = DateTime.Parse(dtp_ngaycap.Text);
            objuse.Noiohientai = txt_tamtru.Text;
            objuse.Dienthoai = txt_sdt.Text;

            objuse.Email = txt_email.Text;
       //     objuse.Tinhtranghonnhan = cmb_tinhtranghonn
            objuse.Trinhdongoaingu = txt_hocvan.Text;
           
            nv.UpdateNhanvien(objuse);
            show();
          
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            //     ServiceReference1.Nhanvien objuse = new ServiceReference1.Nhanvien();
            //     objuse.Ma = txt_manv.Text;
            //     objuse.Ten = txt_hoten.Text;
            ////     objuse.Ngaysinh = DateTime.Parse(dtk_ngaysinh.Text);
            //     Boolean gioiTinh = false;
            //     if (cmb_gioitinh.Text == "Nam")
            //     {
            //         gioiTinh = true;
            //     }
            //     objuse.Gioitinh = gioiTinh;
            //     objuse.Email = txt_email.Text;

            //     try
            //     {
            //         MemoryStream str1 = new MemoryStream();
            //         ptb_anh.Image.Save(str1, System.Drawing.Imaging.ImageFormat.Jpeg);

            //         byte[] pic = str1.ToArray();
            //         objuse.Anh = pic;
            //     }
            //     catch
            //     {
            //         objuse.Anh = null;

            //     }

            //     nv.InsertNhanvien(objuse);
            //     show();
            try
            {
                //Create a new student for demo purpose only
                txt_manv.Text = txt_hoten.Text = dtk_ngaysinh.Text =
                cmb_gioitinh.Text = txt_sdt.Text = txt_email.Text = txt_noisinh.Text = txt_quequan.Text =
                 txt_thuongtru.Text =
                txt_tamtru.Text =
                txt_quoctich.Text =
                txt_tongiao.Text =
                txt_cmtnd.Text =
                dtp_ngaycap.Text =
                txt_noicap.Text =
                txt_ngoaingu.Text =
                txt_dantoc.Text =
                cmb_tinhtranghonnhan.Text = string.Empty;
                frm_them fr = new frm_them();
                fr.Show();
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //Check student is new Student or update Student
                bool isNewStudent = true;
                foreach (DataGridViewRow item in dgv_dsnv.Rows)
                {
                    if (item.Cells[0].Value.ToString() == txt_manv.Text)
                    {
                        isNewStudent = false;
                        break;
                    }
                    
                }
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                //     ServiceReference1.Nhanvien1 nv = new ServiceReference1.Nhanvien1() { Ma = txt_manv.Text, Ten = txt_hoten .Text};
                ServiceReference1.Nhanvien1 nv = new ServiceReference1.Nhanvien1();
                //   ServiceReference1.Nhanvien nv = new ServiceReference1.Nhanvien();

                //  Student oStudent = new Student() { StudentID = int.Parse(txtStudentID.Text), StudentName = txtStudentName.Text, Class = txtClass.Text, Professional = txtProfessional.Text };
                // WCFDemo.WCFServiceDemoClient client = new WCFDemo.WCFServiceDemoClient();
                // oStudent = new Nhanvien() { StudentID = int.Parse(txtStudentID.Text), StudentName = txtStudentName.Text, Class = txtClass.Text, Professional = txtProfessional.Text };
                if (isNewStudent ? client.InsertNhanvien(nv) : client.UpdateNhanvien(nv))
                {
                    DataSet ds = new DataSet();

                    ds = client.LoadNhanvien();
                    dgv_dsnv.DataSource = ds.Tables[0];
                }
                //if (isNewStudent ? client.InsertNhanvien(nv) : client.UpdateNhanvien(nv))
                //{
                //    show();

                //}
                MessageBox.Show("sucess");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_brown_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = openfile.Filter = "JPG file(*.jpg)|*.jpg|All files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                ptb_anh.ImageLocation = openfile.FileName;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = (string)dgv_phongban.CurrentRow.Cells[0].Value;
            nv.DeleteUserDetails(objuse);
            show();
            txt_maphong.Text = "";
            txt_tenphong.Text = "";
            txt_SDTphong.Text = "";
            txt_emailphong.Text = "";
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            int i = dgv_phongban.SelectedCells[0].RowIndex;
            txt_maphong.Text = dgv_phongban.Rows[i].Cells[0].Value.ToString();
            txt_tenphong.Text = dgv_phongban.Rows[i].Cells[1].Value.ToString();
            txt_SDTphong.Text = dgv_phongban.Rows[i].Cells[2].Value.ToString();
            txt_emailphong.Text = dgv_phongban.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_themp_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = txt_maphong.Text;
            objuse.Ten = txt_tenphong.Text;
            objuse.SDT = txt_SDTphong.Text;
            objuse.Email = txt_emailphong.Text;
            nv.InsertUserDetails(objuse);
            show();
        }

        private void btn_suap_Click(object sender, EventArgs e)
        {
            ServiceReference1.phong objuse = new ServiceReference1.phong();
            objuse.Ma = this.dgv_phongban.CurrentRow.Cells[0].Value.ToString();
            objuse.Ten = txt_tenphong.Text;
            objuse.SDT = txt_SDTphong.Text;
            objuse.Email = txt_emailphong.Text;
            nv.Updatephongban(objuse);
            show();
            txt_maphong.Text = "";
            txt_tenphong.Text = "";
            txt_SDTphong.Text = "";
            txt_emailphong.Text = "";

        }
    }
}