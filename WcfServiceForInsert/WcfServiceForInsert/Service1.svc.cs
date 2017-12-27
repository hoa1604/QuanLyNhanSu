using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;



namespace WcfServiceForInsert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //QLNhanSuEntities1 db = new QLNhanSuEntities1();
        QLNhanSuEntities2 db = new QLNhanSuEntities2();

        public bool DeleteNhanvien(Nhanvien useInfo)
        {
            nhanvien nv = new nhanvien();
            nhanvien dt = db.nhanviens.Single(s => s.ma.Equals(useInfo.Ma));
       //     nv.status = 0;
               db.nhanviens.Remove(dt);
            db.SaveChanges();
            return true;
        }

        public bool DeleteUserDetails(phong useInfo)
        {
            phongban dt = db.phongbans.Single(s => s.ma.Equals(useInfo.Ma));
            db.phongbans.Remove(dt);
            db.SaveChanges();
            return true;
        }

        public Boolean InsertNhanvien(Nhanvien useInfo)
        {
           // string Message;
             bool Result = false;
            try
            {
                nhanvien nv = new nhanvien();
                nv.ma = useInfo.Ma;
                nv.ten = useInfo.Ten;
                nv.ngaysinh = useInfo.Ngaysinh;
                nv.anh = useInfo.Anh;
                nv.quequan = useInfo.Quequan;
                nv.noisinh = useInfo.Noisinh;
                nv.hokhauthuongtru = useInfo.Hokhauthuongtru;
         //       nv.diachilienlac = useInfo.Diachilienlac;
                nv.quoctich = useInfo.Quoctich;
                nv.tongiao = useInfo.Tongiao;
                nv.soCMT = useInfo.CMT;
                nv.ngaycap = useInfo.Ngaycap;
                nv.noiohiennay = useInfo.Noiohientai;
                nv.dienthoai = useInfo.Dienthoai;
                nv.email = useInfo.Email;
                nv.tinhtranghonnhan = useInfo.Tinhtranghonnhan;
                nv.trinhdongoaingu = useInfo.Trinhdongoaingu;
                nv.dantoc = useInfo.Dantoc;
                db.nhanviens.Add(nv);
                try { db.SaveChanges(); }
                catch (Exception ex)
                {
                    Result = false;
                  //  string MessageBox = null;
                 //   MessageBox= ("Lỗi" + ex);
                }
            //    Message = useInfo.Ten + "Success";
                   Result = true;
            }
            catch (Exception)
            {
             //   Message = useInfo.Ten + "Thêm Thất bại!!";
                  Result = false;
            }
              return Result;
        ///    return Message; 
        }


        public string InsertUserDetails(phong useInfo)
        {
            string Message;
            try
            {

                phongban dt = new phongban();
                dt.ma = useInfo.Ma;
                dt.ten = useInfo.Ten;
                dt.sdt = useInfo.SDT;
                dt.email = useInfo.Email;
                db.phongbans.Add(dt);
                db.SaveChanges();
                Message = useInfo.Ten + "Success";
            }
            catch
            {
                Message = useInfo.Ten + "Thêm Thất bại!!";
            }
            return Message;
        }

        public DataSet LoadNhanvien()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MON8K1N\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True");
            con.Open();

            //    SqlCommand cmd = new SqlCommand("select ma as N'Mã',ten as N'Họ tên',ngaysinh as N'Ngày sinh', CASE WHEN gioitinh = 1 Then 'Nam'ELSE N'Nữ'END AS 'GioiTinh',email, anh as N'Ảnh'  from nhanvien" , con);
            SqlCommand cmd = new SqlCommand("select nhanvien.*, hopdonglaodongnhanvien.*, CASE WHEN gioitinh = 1 Then 'Nam'ELSE N'Nữ'END as 'Giới tính',  CASE WHEN tinhtranghonnhan = 1 Then 'Đã kết hôn 'ELSE N'Chưa kết hôn'END as 'Tình trạng hôn nhân' from nhanvien,  hopdonglaodongnhanvien  where nhanvien.hopdonglaodongnhanvienma=hopdonglaodongnhanvien.ma  ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public void LOADNV(Nhanvien useInfo)
        {
         //   string id;
            nhanvien nv = db.nhanviens.Single(s => s.ma==useInfo.Ma);
        }
      
        public DataSet SelectUserDetails()
        {

       
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MON8K1N\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select*from phongban", con);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public bool UpdateNhanvien(Nhanvien useInfo)
        {
            bool Result = false;
            try
            {
           
              nhanvien nv= db.nhanviens.Single(s => s.ma.Equals(useInfo.Ma)); 
                nv.ten = useInfo.Ten;
                nv.gioitinh = useInfo.Gioitinh;
                nv.ngaysinh = useInfo.Ngaysinh;
                nv.anh = useInfo.Anh;
                nv.quequan = useInfo.Quequan;
                nv.noisinh = useInfo.Noisinh;
                nv.hokhauthuongtru = useInfo.Hokhauthuongtru;
           //     nv.diachilienlac = useInfo.Diachilienlac;
                nv.quoctich = useInfo.Quoctich;
                nv.tongiao = useInfo.Tongiao;
                nv.soCMT = useInfo.CMT;
                nv.ngaycap = useInfo.Ngaycap;
                nv.noiohiennay = useInfo.Noiohientai;
                nv.dienthoai = useInfo.Dienthoai;
                nv.email = useInfo.Email;
              //  nv.tinhtranghonnhan = useInfo.Tinhtranghonnhan;
                nv.trinhdongoaingu = useInfo.Trinhdongoaingu;
             //   nv.dantoc = useInfo.Dantoc;
                db.SaveChanges();
                    Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
            return Result;
        }
     

        public void Updatephongban(phong useInfo)
        {

            phongban dt = db.phongbans.Single(s => s.ma.Equals(useInfo.Ma)); ;
          //  dt.ma = useInfo.Ma;
            dt.ten = useInfo.Ten;
            dt.sdt = useInfo.SDT;
            dt.email = useInfo.Email;
        //    db.phongbans.Add(dt);
            db.SaveChanges();
           

        }

        public List<nhanvien> findALL()
        {
            return db.nhanviens.ToList();
    
    }

        public nhanvien find(string id)
        {
            return db.nhanviens.Single(s => s.ma == id);
        }

        phongban IService1.findpb(string id)
        {
            return db.phongbans.Single(s => s.ma == id);
        }

        public List<phongban> Loadpb()
        {
            return db.phongbans.ToList();

        }



        //qua trinh thay doi _ Hoa
        public Dictionary<string, string> CobNhanVien()
        {
          
            Dictionary<string, string> cobNhanVien = new Dictionary<string, string>();
            foreach(var item in db.nhanviens)
            {
                cobNhanVien.Add(item.ma.ToString(), item.ten.ToString());
            }
           
            return cobNhanVien;
        }
        public Dictionary<string, string> CobPhongBan()
        {

            Dictionary<string, string> cobPhongBan = new Dictionary<string, string>();
            foreach (var item in db.phongbans)
            {
                cobPhongBan.Add(item.ma.ToString(), item.ten.ToString());
            }

            return cobPhongBan;
        }
        public bool InsertNhanVienPhongBan(nhanvienphongban2 nv)
        {
            var nhanvien = new nhanvienphongban();
            nhanvien.nhanvienma = nv.Nhanvienma;
            nhanvien.phongbanma = nv.Phongbanma;
            nhanvien.ma = nv.Ma;
            nhanvien.ngaychuyenphong = nv.Ngaychuyenphong;
            db.nhanvienphongbans.Add(nhanvien);
            try
            {
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
           
        }
      
    }
}
