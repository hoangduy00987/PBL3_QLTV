//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL_3
{
    using System;
    using System.Collections.Generic;
    
    public partial class STAFF
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ROLE { get; set; }
        public string PHONENUMBER { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}