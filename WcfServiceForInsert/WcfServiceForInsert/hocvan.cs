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
    
    public partial class hocvan
    {
        public hocvan()
        {
            this.luongcobans = new HashSet<luongcoban>();
            this.nhanvienhocvans = new HashSet<nhanvienhocvan>();
        }
    
        public string ma { get; set; }
        public string ten { get; set; }
    
        public virtual ICollection<luongcoban> luongcobans { get; set; }
        public virtual ICollection<nhanvienhocvan> nhanvienhocvans { get; set; }
    }
}