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
    
    public partial class chamcong
    {
        public string nhanvienma { get; set; }
        public string mangaycong { get; set; }
        public Nullable<System.DateTime> ngaycong { get; set; }
        public string tinhtrang { get; set; }
        public Nullable<double> sogiolamthem { get; set; }
    
        public virtual nhanvien nhanvien { get; set; }
    }
}
