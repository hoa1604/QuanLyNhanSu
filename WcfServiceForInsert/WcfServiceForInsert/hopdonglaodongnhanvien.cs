//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceForInsert
{
    using System;
    using System.Collections.Generic;
    
    public partial class hopdonglaodongnhanvien
    {
        public hopdonglaodongnhanvien()
        {
            this.nhanviens = new HashSet<nhanvien>();
        }
    
        public string ma { get; set; }
        public Nullable<System.DateTime> ngayky { get; set; }
        public Nullable<System.DateTime> ngaybatdau { get; set; }
        public Nullable<System.DateTime> ngayketthuc { get; set; }
        public Nullable<decimal> luongthuviec { get; set; }
        public string ten { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual ICollection<nhanvien> nhanviens { get; set; }
    }
}