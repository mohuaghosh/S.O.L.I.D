using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._2_OCP.Compliance
{
    public class FullTimeStudent : IStudent
    {
        public string StudentType()
        {
            return "Full-Time";
        }

        List<string> IStudent.GetStudentSubjects()
        {
            return new List<string>();
        }

       
    }

}


