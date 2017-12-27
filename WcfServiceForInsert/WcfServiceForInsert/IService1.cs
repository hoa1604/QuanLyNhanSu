using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfServiceForInsert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertUserDetails(phong useInfo);


        [OperationContract]
          DataSet SelectUserDetails();
     //   List<phong> SelectUserDetails();
        [OperationContract]
        bool DeleteUserDetails(phong useInfo);
        [OperationContract]
        void  Updatephongban(phong useInfo);

        [OperationContract]
        phongban findpb(string id);
        [OperationContract]
        List<phongban> Loadpb();

        // TODO: Add your service operations here
        [OperationContract]
        Boolean InsertNhanvien(Nhanvien useInfo);


        [OperationContract]
        DataSet LoadNhanvien();
        //   List<phong> SelectUserDetails();
        [OperationContract]
        void LOADNV(Nhanvien useInfo);
        [OperationContract]
        nhanvien find(string id);
        [OperationContract]
        List<nhanvien> findALL();

        [OperationContract]
        bool DeleteNhanvien(Nhanvien useInfo);
        [OperationContract]
       Boolean UpdateNhanvien(Nhanvien useInfo);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Nhanvien
    {
        string ma;
        string ten;
        DateTime ngaysinh;
        Boolean gioitinh;
        byte[] anh;
        string quequan;
        string noisinh;
        string hokhauthuongtru;
        string diachilienlac;
        string quoctich;
        string tongiao;
        string soCMT;
        DateTime ngaycap;
        string noicap;
        string noiohientai;
        string dienthoai;
        string email;
        Boolean trinhtranghonnhan;
        string trinhdongoaingu;
        string dantoc;
        [DataMember]
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        [DataMember]
        public string Ten
        {
            get { return ten; }
            set {ten = value; }
        }
        [DataMember]
        public DateTime Ngaysinh {
            get { return ngaysinh;}
            set { ngaysinh = value; }
        }


        [DataMember]
        public Boolean Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        [DataMember]
        public byte[] Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        [DataMember]
        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        [DataMember]
        public string Noisinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        } 
        [DataMember]
        public string Hokhauthuongtru
        {
            get { return hokhauthuongtru; }
            set { hokhauthuongtru= value; }
        }
     
        [DataMember]
        public string Diachilienlac
        {
            get { return diachilienlac; }
            set { diachilienlac = value; }
        }
        [DataMember]
        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }
       
        [DataMember]
        public string Tongiao
        {
            get { return tongiao; }
            set { tongiao = value; }
        }
        [DataMember]
        public string CMT
        {
            get { return soCMT; }
            set { soCMT = value; }
        }
        [DataMember]
        public DateTime Ngaycap
        {
            get { return ngaycap; }
            set { ngaycap = value; }
        }
        [DataMember]
        public string Noicap
        {
            get { return noicap; }
            set { noicap = value; }
        }
        [DataMember]
        public string Noiohientai
        {
            get { return noiohientai; }
            set { noiohientai = value; }
        }
    
        [DataMember]
        public string Dienthoai
        {
            get { return dienthoai ; }
            set { dienthoai = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        [DataMember]
        public Boolean Tinhtranghonnhan
        {
            get { return trinhtranghonnhan; }
            set { trinhtranghonnhan = value; }
        }
    
        [DataMember]
        public string Trinhdongoaingu
        {
            get { return trinhdongoaingu; }
            set { trinhdongoaingu = value; }
        }
        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }


    }
    

    [DataContract]
    public class phong
    {
        string ma;
        string ten;
        string sdt;
        string email;


        [DataMember]
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        [DataMember]
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        [DataMember]
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    
}
    [DataContract]
    public class hopdonglaodong
    {
        string ma;
        DateTime ngaydangky;
        DateTime ngaybatdau;
        DateTime ngayketthuc;
        string luongthuviec;


        [DataMember]
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        [DataMember]
        public DateTime Ngaydangky
        {
            get { return ngaydangky; }
            set { ngaydangky = value; }
        }
        [DataMember]
        public DateTime Ngaybatdau
                    {
            get { return ngaybatdau; }
            set { ngaybatdau= value; }
        }
        [DataMember]
        public DateTime Ngayketthuc
        {
            get { return ngayketthuc; }
            set {ngayketthuc = value; }
        }

    }
}