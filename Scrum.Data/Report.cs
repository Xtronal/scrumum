//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scrum.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public Report()
        {
            this.Reciepts = new HashSet<Reciept>();
            this.TravelInfoes = new HashSet<TravelInfo>();
        }
    
        public int RID { get; set; }
        public int UID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Kilometers { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual ICollection<Reciept> Reciepts { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TravelInfo> TravelInfoes { get; set; }
    }
}
