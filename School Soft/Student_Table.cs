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
    
    public partial class Student_Table
    {
        public string UserID { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> Contact { get; set; }
        public int Fee_Status { get; set; }
        public string Course_ID { get; set; }
    
        public virtual Course_Table Course_Table { get; set; }
        public virtual Login_Table Login_Table { get; set; }
    }
}
