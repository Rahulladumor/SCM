//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMSProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseTB
    {
        public CourseTB()
        {
            this.AttendanceTBs = new HashSet<AttendanceTB>();
            this.ExamTBs = new HashSet<ExamTB>();
            this.FeesdetailsTBs = new HashSet<FeesdetailsTB>();
            this.PaymentTBs = new HashSet<PaymentTB>();
            this.StudentTBs = new HashSet<StudentTB>();
            this.SubjectTBs = new HashSet<SubjectTB>();
        }
    
        public int Course_id { get; set; }
        public string Course_name { get; set; }
        public int Course_fees { get; set; }
        public int Course_duration { get; set; }
    
        public virtual ICollection<AttendanceTB> AttendanceTBs { get; set; }
        public virtual ICollection<ExamTB> ExamTBs { get; set; }
        public virtual ICollection<FeesdetailsTB> FeesdetailsTBs { get; set; }
        public virtual ICollection<PaymentTB> PaymentTBs { get; set; }
        public virtual ICollection<StudentTB> StudentTBs { get; set; }
        public virtual ICollection<SubjectTB> SubjectTBs { get; set; }
    }
}
