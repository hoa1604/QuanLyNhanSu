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
    
    public partial class phucap
    {
        public phucap()
        {
            this.luongnhanviens = new HashSet<luongnhanvien>();
        }
    
        public string chucvuma { get; set; }
        public string ma { get; set; }
        public string heso { get; set; }
    
        public virtual chucvu chucvu { get; set; }
        public virtual ICollection<luongnhanvien> luongnhanviens { get; set; }
    }
}