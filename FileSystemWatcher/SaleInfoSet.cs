//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileSystemWatcher
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleInfoSet
    {
        public int ManagerID { get; set; }
        public string ClientName { get; set; }
        public string Product { get; set; }
        public System.DateTime Date { get; set; }
        public int Cost { get; set; }
        public int Manager_ManagerID { get; set; }
    
        public virtual ManagerSet ManagerSet { get; set; }
    }
}
