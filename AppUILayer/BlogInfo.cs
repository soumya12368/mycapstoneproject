//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUILayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogInfo
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public System.DateTime DateOfCreation { get; set; }
        public string BlogUrl { get; set; }
        public string EmpEmailId { get; set; }
    
        public virtual EmpInfo EmpInfo { get; set; }
    }
}
