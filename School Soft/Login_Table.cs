//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Soft
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login_Table
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public int Admin_Status { get; set; }
    
        public virtual Student_Table Student_Table { get; set; }
    }
}
