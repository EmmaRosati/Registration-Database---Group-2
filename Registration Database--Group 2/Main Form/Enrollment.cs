//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main_Form
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int Id { get; set; }
        public int SectionID { get; set; }
        public int StudentID { get; set; }
        public string Grade { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual Student Student { get; set; }
    }
}
