//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LectureCourse
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public int CourseId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Lecture Lecture { get; set; }
    }
}
