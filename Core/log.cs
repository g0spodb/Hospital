//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class log
    {
        public int id { get; set; }
        public Nullable<int> id_pat { get; set; }
        public Nullable<int> id_room { get; set; }
        public Nullable<System.DateTime> trans_date { get; set; }
        public string discharge { get; set; }
        public string date_discharge { get; set; }
        public string reason_for_discharge { get; set; }
    
        public virtual patient patient { get; set; }
        public virtual room room { get; set; }
    }
}
