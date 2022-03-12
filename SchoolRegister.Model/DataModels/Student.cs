using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public double AverageGrade { get; }
        public IDictionary<string,List<GradeScale>> AverageGradePerSubject { get; }
        public IList<Grade> Grades { get; set; }
        public IDictionary<string,List<GradeScale>> GradesPerSubject { get; }
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
    }
}