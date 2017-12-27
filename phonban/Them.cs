using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ServiceModel;


namespace phonban
{
    public partial class frm_them : Form
    {

     //  private string id;
        private string path;
        ServiceReference1.Service1Client nv = new ServiceReference1.Service1Client();
         ServiceReference2.Nhanvien objuse = new ServiceReference2.Nhanvien();
        public frm_them()
        {

   
            InitializeComponent();



   
        }
        private void Sua_Load(object sender, EventArgs e) {
            load();
           
        }
        public void load()
        {

            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Hide();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            ServiceReference1.Nhanvien1 objuse = new ServiceReference1.Nhanvien1();
            objuse.Ma = txt_manv.Text;
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


            nv.InsertNhanvien(objuse);
            Form1 fr = new Form1();
            fr.Show(this);
            Hide();
            fr.show();
         
        }
    }
    }
